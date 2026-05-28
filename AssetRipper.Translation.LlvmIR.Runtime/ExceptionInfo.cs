using System.Runtime.ExceptionServices;

namespace AssetRipper.Translation.LlvmIR.Runtime;

public class ExceptionInfo(string? message = null) : Exception(message), IDisposable
{
	[ThreadStatic]
	public static ExceptionInfo? Current;

	/// <summary>
	/// The exception currently being processed inside an Itanium landing-pad block.
	/// Set by <see cref="BeginLandingPad"/> and cleared in <see cref="ResumePropagation"/>.
	/// </summary>
	[ThreadStatic]
	public static ExceptionInfo? BeingHandled;

	/// <summary>
	/// Gets the C++ exception object pointer for use by the Itanium ABI
	/// (<c>__cxa_begin_catch</c>). Returns null by default; override in
	/// derived classes that wrap a native C++ heap allocation.
	/// </summary>
	public virtual unsafe void* ClientExceptionObject => null;

	/// <summary>
	/// Gets the Itanium <c>type_info*</c> pointer associated with the current
	/// exception object. Returns null by default for non-Itanium exceptions.
	/// </summary>
	public virtual unsafe void* ClientTypeInfo => null;

	/// <summary>
	/// Mirrors <c>llvm.eh.typeid.for</c> behavior in a stable managed form.
	/// </summary>
	public static unsafe int GetTypeIdFor(void* typeInfo)
	{
		if (typeInfo is null)
		{
			// Keep 1 as the dedicated catch-all/null type id.
			return 1;
		}

		unchecked
		{
			long raw = (long)(nint)typeInfo;
			int folded = (int)(raw ^ (raw >> 32));
			if (folded == 0)
			{
				folded = 2;
			}
			else if (folded == 1)
			{
				folded = 3;
			}
			return folded;
		}
	}

	/// <summary>
	/// Updates an in-progress landing-pad selector using one catch clause.
	/// Returns <paramref name="currentSelector"/> unchanged once a prior clause matched.
	/// </summary>
	public static unsafe int UpdateLandingPadSelector(int currentSelector, void* clauseTypeInfo)
	{
		if (currentSelector != 0)
		{
			return currentSelector;
		}

		if (clauseTypeInfo is null)
		{
			// Catch-all clause.
			return GetTypeIdFor(null);
		}

		ExceptionInfo? beingHandled = BeingHandled;
		void* activeTypeInfo = beingHandled is null ? null : beingHandled.ClientTypeInfo;
		if (activeTypeInfo == clauseTypeInfo)
		{
			return GetTypeIdFor(clauseTypeInfo);
		}

		return 0;
	}

	/// <summary>
	/// Called by translated landing-pad blocks when the LLVM landingpad aggregate result
	/// is not consumed by subsequent instructions. Updates exception state without creating
	/// a managed IL dependency on unmanaged pointer locals.
	/// </summary>
	public static void BeginLandingPadWithoutResult()
	{
		ExceptionInfo? exc = Current;
		Current = null;
		BeingHandled = exc;
	}

	/// <summary>
	/// Like <see cref="BeginLandingPad"/> but returns the exception object pointer as a
	/// <c>nint</c> (native int) instead of <c>void*</c>. Using <c>nint</c> keeps the
	/// translated method body verifiable when the method also contains CLR EH regions
	/// (the verifier rejects <c>void*</c> locals in methods with exception handlers).
	/// </summary>
	public static unsafe nint BeginLandingPadAsNInt() => (nint)BeginLandingPad();

	/// <summary>
	/// Called by translated landing-pad blocks immediately after control transfers
	/// to the unwind successor.  Moves <see cref="Current"/> into
	/// <see cref="BeingHandled"/>, clears <see cref="Current"/> so that subsequent
	/// calls within the catch body do not see a stale "exception in flight" sentinel,
	/// and returns the C++ exception object pointer for field&nbsp;0 of the
	/// <c>{ i8*, i32 }</c> landing-pad result struct.
	/// </summary>
	public static unsafe void* BeginLandingPad()
	{
		ExceptionInfo? exc = Current;
		BeginLandingPadWithoutResult();
		if (exc is not null)
			return exc.ClientExceptionObject;
		return null;
	}

	/// <summary>
	/// Called by translated <c>resume</c> blocks to re-propagate the exception
	/// that was caught by the landing pad but not handled by any catch clause.
	/// Clears <see cref="BeingHandled"/> and rethrows via
	/// <see cref="ExceptionDispatchInfo"/> so the original stack trace is preserved.
	/// </summary>
	[System.Diagnostics.CodeAnalysis.DoesNotReturn]
	public static void ResumePropagation()
	{
		ExceptionInfo? exc = BeingHandled;
		BeingHandled = null;
		if (exc is not null)
		{
			ExceptionDispatchInfo.Capture(exc).Throw();
		}
		throw new InvalidOperationException("LLVMResume called with no active landing-pad exception.");
	}

	public virtual string? GetMessage()
	{
		return null;
	}

	protected virtual void Dispose(bool disposing) { }

	~ExceptionInfo()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: false);
	}

	public void Dispose()
	{
		// Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}
}
