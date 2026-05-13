using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_12AllocChecker5allocEmRS0_")]
[DemangledName("__llvm_libc_20_1_2_::AllocChecker::alloc(unsigned long, __llvm_libc_20_1_2_::AllocChecker&)")]
internal static partial class AllocChecker_alloc_unsigned_long_AllocChecker
{
	public unsafe static void* Invoke(long s, void* ac)
	{
		void* ptr = null;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = malloc.Invoke(s);
		AllocChecker_operator_bool.Invoke(ac, ptr != null);
		void* result = ptr;
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		return result;
	}
}
