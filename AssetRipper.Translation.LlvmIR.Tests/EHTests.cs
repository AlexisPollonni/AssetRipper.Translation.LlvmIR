using AssetRipper.Translation.LlvmIR.Runtime;

namespace AssetRipper.Translation.LlvmIR.Tests;

public class EHTests
{
	private const string InvokeLandingPadCleanup = """
		declare i32 @__gxx_personality_v0(...)

		define dso_local void @may_fail() {
		  ret void
		}

		define dso_local void @invoke_passthrough() personality ptr @__gxx_personality_v0 {
		entry:
		  invoke void @may_fail()
		          to label %ok unwind label %lpad

		ok:
		  ret void

		lpad:
		  %0 = landingpad { ptr, i32 }
		          cleanup
		  ret void
		}
		""";

	private const string LandingPadTypedCatchAndResume = """
		declare i32 @__gxx_personality_v0(...)
		declare i32 @llvm.eh.typeid.for(ptr)
		@_ZTIi = external global i8

		define dso_local void @always_throw() {
		entry:
		  unreachable
		}

		define dso_local i32 @typed_catch_selector() personality ptr @__gxx_personality_v0 {
		entry:
		  invoke void @always_throw()
		          to label %ok unwind label %lpad

		ok:
		  ret i32 0

		lpad:
		  %0 = landingpad { ptr, i32 }
		          catch ptr @_ZTIi
		  %1 = extractvalue { ptr, i32 } %0, 1
		  %2 = call i32 @llvm.eh.typeid.for(ptr @_ZTIi)
		  %3 = icmp eq i32 %1, %2
		  br i1 %3, label %caught, label %rethrow

		caught:
		  ret i32 1

		rethrow:
		  resume { ptr, i32 } %0
		}
		""";

	private const string WinEhCatchSwitchCatchPadCatchRet = """
		declare i32 @__CxxFrameHandler3(...)

		define dso_local void @callee_void() {
		entry:
		  ret void
		}

		define dso_local void @wineh_catch() personality ptr @__CxxFrameHandler3 {
		entry:
		  invoke void @callee_void()
		          to label %try.cont unwind label %catch.dispatch

		catch.dispatch:
		  %0 = catchswitch within none [label %catch] unwind to caller

		catch:
		  %1 = catchpad within %0 [ptr null]
		  catchret from %1 to label %try.cont

		try.cont:
		  ret void
		}
		""";

	private const string WinEhCleanupPadCleanupRet = """
		declare i32 @__CxxFrameHandler3(...)

		define dso_local void @callee_void_cleanup() {
		entry:
		  ret void
		}

		define dso_local void @wineh_cleanup() personality ptr @__CxxFrameHandler3 {
		entry:
		  invoke void @callee_void_cleanup()
		          to label %ret unwind label %cleanup

		cleanup:
		  %0 = cleanuppad within none []
		  cleanupret from %0 unwind to caller

		ret:
		  ret void
		}
		""";

	[Test]
	public async Task InvokeLandingPadCleanup_RuntimeExecution_ExecutesWithoutThrowing()
	{
		await ExecutionHelpers.RunTest(InvokeLandingPadCleanup.TranslateToCIL(), async assembly =>
		{
			Action method = ExecutionHelpers.GetMethod<Action>(assembly, "invoke_passthrough");
			method.Invoke();
			await Task.CompletedTask;
		});
	}

	public static IEnumerable<TestDataRow<string>> GetEhIrCases()
	{
		yield return new(InvokeLandingPadCleanup)
		{
			DisplayName = nameof(InvokeLandingPadCleanup),
		};
		yield return new(LandingPadTypedCatchAndResume)
		{
			DisplayName = nameof(LandingPadTypedCatchAndResume),
		};
		yield return new(WinEhCatchSwitchCatchPadCatchRet)
		{
			DisplayName = nameof(WinEhCatchSwitchCatchPadCatchRet),
		};
		yield return new(WinEhCleanupPadCleanupRet)
		{
			DisplayName = nameof(WinEhCleanupPadCleanupRet),
		};
	}

	[Test]
	[MethodDataSource(nameof(GetEhIrCases))]
	public Task EhIr_SavesSuccessfully(string llvmCode)
	{
		return AssertionHelpers.AssertSavesSuccessfully(llvmCode.TranslateToCIL());
	}

	[Test]
	[MethodDataSource(nameof(GetEhIrCases))]
	public Task EhIr_DecompilesSuccessfully(string llvmCode)
	{
		return AssertionHelpers.AssertDecompilesSuccessfully(llvmCode.TranslateToCIL());
	}

	[Test]
	public void ExitToUserCode_ClearsStackFrames()
	{
		// ExitToUserCode no longer checks ExceptionInfo.Current; it simply clears
		// stack frames. Exceptions propagate through real CLR EH regions instead.
		StackFrameList.ExitToUserCode();
		// Should complete without throwing.
	}
}
