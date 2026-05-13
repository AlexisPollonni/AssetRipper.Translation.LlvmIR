using System.Threading;

namespace AssetRipper.Translation.LlvmIR;

#pragma warning disable IDE0060 // Remove unused parameter
internal static unsafe partial class IntrinsicFunctions
{
	// ── x87 FPU / SSE environment stubs ──────────────────────────────────────
	// These are called via InlineAssemblySubstitutions when llvm-libc emits
	// inline assembly for x87/SSE FPU environment reads and writes.
	// In a managed (.NET) host the FPU environment is not directly accessible,
	// so we provide safe stubs:
	//   Reads  → write the x87/SSE power-on-default values to the output buffer.
	//   Writes → no-op (ignore the requested fp-env value).
	//   Math   → delegate to Math/MathF.

	// ── fnstenv $0  (store x87 FPU environment, 28-byte struct) ─────────────
	public static void AsmFnstenv(void* mem)
	{
		if (mem == null)
			return;
		byte* p = (byte*)mem;
		new Span<byte>(p, 28).Clear();
		*(ushort*)(p + 0) = 0x037F;
		*(ushort*)(p + 8) = 0xFFFF;
	}

	// ── stmxcsr $0  (store MXCSR) ────────────────────────────────────────────
	// Stores the SSE control/status register (exception masks, rounding mode,
	// FTZ, DAZ) to memory. .NET's managed intrinsics API has no way to read
	// MXCSR from managed code, so we return the power-on default (0x1F80:
	// all FP exceptions masked, round-to-nearest, no FTZ/DAZ).
	public static void AsmStmxcsr(int* mem)
	{
		if (mem != null)
			*mem = 0x1F80;
	}

	// ── fldenv $0  (load x87 FPU environment) ────────────────────────────────
	public static void AsmFldenv(
		void* mem
	) { /* no-op in managed host */
	}

	// ── ldmxcsr $0  (load MXCSR) ─────────────────────────────────────────────
	// Loads a new value into the SSE MXCSR register. No managed API exists to
	// set MXCSR, so requests to change rounding mode / exception masks are
	// silently ignored.
	public static void AsmLdmxcsr(
		int* mem
	) { /* no-op in managed host */
	}

	// ── fwait  (synchronize FPU) ──────────────────────────────────────────────
	public static void AsmFwait() { /* no-op in managed host */
	}

	// ── fsqrt  (x87 scalar double square root) ────────────────────────────────
	public static double AsmFsqrt(double x) => Math.Sqrt(x);

	// ── sqrtss ${1:x}, ${0:x}  (SSE scalar float square root) ────────────────
	public static float AsmSqrtss(float x) => MathF.Sqrt(x);

	// ── sqrtsd ${1:x}, ${0:x}  (SSE scalar double square root) ──────────────
	public static double AsmSqrtsd(double x) => Math.Sqrt(x);

	// ── fnstsw $0  (store x87 FPU status word to mem) ────────────────────────
	// Status word = 0 means no exceptions, no condition codes set.
	public static void AsmFnstsw(short* mem)
	{
		if (mem != null)
			*mem = 0;
	}

	// ── fnstcw $0  (store x87 FPU control word to mem) ───────────────────────
	// 0x037F = round-to-nearest, extended precision, all exceptions masked.
	public static void AsmFnstcw(short* mem)
	{
		if (mem != null)
			*mem = 0x037F;
	}

	// ── fldcw $0  (load x87 FPU control word from mem) ───────────────────────
	public static void AsmFldcw(
		short* mem
	) { /* no-op in managed host */
	}

	// ── empty asm with register+memory clobber ────────────────────────────────
	// Emitted by llvm-libc as an optimization barrier / compiler fence.
	// In managed code a full memory barrier (Thread.MemoryBarrier) is sufficient.
	public static void AsmMemoryBarrierPtr(void* ptr)
	{
		Thread.MemoryBarrier();
	}
}
#pragma warning restore IDE0060 // Remove unused parameter
