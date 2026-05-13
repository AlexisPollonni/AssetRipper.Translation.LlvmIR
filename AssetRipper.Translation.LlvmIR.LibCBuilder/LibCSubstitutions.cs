namespace AssetRipper.Translation.LlvmIR.LibCBuilder;

/// <summary>
/// Mapping from llvm-libc inline assembly (asm-text, constraint-string) pairs to
/// the name of the <c>IntrinsicFunctions</c> method that should be called
/// instead of emitting a <c>throw new NotImplementedException</c> stub.
/// </summary>
/// <remarks>
/// <para>
/// Each <c>syscall</c> asm variant in llvm-libc uses the same asm text
/// (<c>"syscall"</c>) but a unique constraint string that encodes the number of
/// arguments via the register list:
/// ax = syscall number, di/si/dx/r10/r8/r9 = arguments 1–6.
/// </para>
/// <para>
/// The FPU environment constraints map to lightweight stubs that write x87/SSE
/// power-on-default values or are no-ops, since the managed (.NET) host cannot
/// directly access the x87/SSE FPU control registers.
/// </para>
/// </remarks>
internal static class LibCSubstitutions
{
	// Constraint string shared clobber suffix (all syscall variants end with this).
	private const string SyscallClobberSuffix =
		"~{rcx},~{r11},~{memory},~{dirflag},~{fpsr},~{flags}";

	private const string Syscall = "syscall";
	private const string FpuClobber = "~{dirflag},~{fpsr},~{flags}";

	public static Dictionary<(string Asm, string Constraints), string> Build() =>
		new()
		{
			// ── syscall – 1 argument (syscall number only) ────────────────────
			[(Syscall, $"={{ax}},{{ax}},{SyscallClobberSuffix}")] = "SyscallN1",

			// ── syscall – 2 arguments (n, a1) ─────────────────────────────────
			[(Syscall, $"={{ax}},{{ax}},{{di}},{SyscallClobberSuffix}")] = "SyscallN2",

			// ── syscall – 3 arguments (n, a1, a2) ────────────────────────────
			[(Syscall, $"={{ax}},{{ax}},{{di}},{{si}},{SyscallClobberSuffix}")] = "SyscallN3",

			// ── syscall – 4 arguments (n, a1, a2, a3) ────────────────────────
			[(Syscall, $"={{ax}},{{ax}},{{di}},{{si}},{{dx}},{SyscallClobberSuffix}")] =
				"SyscallN4",

			// ── syscall – 5 arguments (n, a1, a2, a3, a4) ────────────────────
			[(Syscall, $"={{ax}},{{ax}},{{di}},{{si}},{{dx}},{{r10}},{SyscallClobberSuffix}")] =
				"SyscallN5",

			// ── syscall – 6 arguments (n, a1, a2, a3, a4, a5) ───────────────
			[
				(
					Syscall,
					$"={{ax}},{{ax}},{{di}},{{si}},{{dx}},{{r10}},{{r8}},{SyscallClobberSuffix}"
				)
			] = "SyscallN6",

			// ── syscall – 7 arguments (n, a1, a2, a3, a4, a5, a6) ───────────
			[
				(
					Syscall,
					$"={{ax}},{{ax}},{{di}},{{si}},{{dx}},{{r10}},{{r8}},{{r9}},{SyscallClobberSuffix}"
				)
			] = "DotnetSyscall",

			// ── x87 / SSE FPU environment reads ──────────────────────────────

			// fnstenv $0  (store 28-byte x87 FPU environment to memory)
			[("fnstenv $0", $"=*m,{FpuClobber}")] = "AsmFnstenv",

			// stmxcsr $0  (store MXCSR register to memory)
			[("stmxcsr $0", $"=*m,{FpuClobber}")] = "AsmStmxcsr",

			// fnstsw $0  (store x87 FPU status word to memory)
			[("fnstsw $0", $"=*m,{FpuClobber}")] = "AsmFnstsw",

			// fnstcw $0  (store x87 FPU control word to memory)
			[("fnstcw $0", $"=*m,{FpuClobber}")] = "AsmFnstcw",

			// ── x87 / SSE FPU environment writes (no-ops in managed host) ────

			// fldenv $0  (load x87 FPU environment from memory)
			[("fldenv $0", $"*m,{FpuClobber}")] = "AsmFldenv",

			// ldmxcsr $0  (load MXCSR register from memory)
			[("ldmxcsr $0", $"*m,{FpuClobber}")] = "AsmLdmxcsr",

			// fldcw $0  (load x87 FPU control word from memory)
			[("fldcw $0", $"*m,{FpuClobber}")] = "AsmFldcw",

			// fwait  (synchronize x87 FPU — no-op in managed host)
			[("fwait", FpuClobber)] = "AsmFwait",

			// ── x87 / SSE square root ─────────────────────────────────────────

			// fsqrt  (x87 scalar double sqrt)
			[("fsqrt", $"={{st}},0,{FpuClobber}")] = "AsmFsqrt",

			// sqrtss ${1:x}, ${0:x}  (SSE scalar float sqrt)
			[("sqrtss ${1:x}, ${0:x}", $"=x,x,{FpuClobber}")] = "AsmSqrtss",

			// sqrtsd ${1:x}, ${0:x}  (SSE scalar double sqrt)
			[("sqrtsd ${1:x}, ${0:x}", $"=x,x,{FpuClobber}")] = "AsmSqrtsd",

			// ── Compiler / optimization fence ─────────────────────────────────
			// Empty asm with register + memory clobber — emitted as a barrier.
			[("", "r,~{memory},~{dirflag},~{fpsr},~{flags}")] = "AsmMemoryBarrierPtr",
		};
}
