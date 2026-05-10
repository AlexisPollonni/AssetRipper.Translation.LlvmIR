using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZnwmRN19__llvm_libc_20_1_2_12AllocCheckerE")]
[DemangledName("operator new(unsigned long, __llvm_libc_20_1_2_::AllocChecker&)")]
[CleanName("operator_new_unsigned_long_AllocChecker")]
internal static partial class operator_new_unsigned_long_AllocChecker_x3ybds
{
	public unsafe static void* Invoke(long size, void* ac)
	{
		return AllocChecker_alloc_unsigned_long_AllocChecker.Invoke(size, ac);
	}
}
