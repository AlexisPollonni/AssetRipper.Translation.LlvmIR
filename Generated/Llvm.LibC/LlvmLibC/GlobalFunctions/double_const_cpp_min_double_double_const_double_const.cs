using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3minIdEERKT_S4_S4_")]
[DemangledName("double const& __llvm_libc_20_1_2_::cpp::min<double>(double const&, double const&)")]
internal static partial class double_const_cpp_min_double_double_const_double_const
{
	public unsafe static void* Invoke(void* a, void* b)
	{
		return (!unchecked(*(double*)a < *(double*)b)) ? b : a;
	}
}
