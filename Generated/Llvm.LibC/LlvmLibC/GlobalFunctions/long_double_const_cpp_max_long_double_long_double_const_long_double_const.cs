using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIeEERKT_S4_S4_")]
[DemangledName("long double const& __llvm_libc_20_1_2_::cpp::max<long double>(long double const&, long double const&)")]
internal static partial class long_double_const_cpp_max_long_double_long_double_const_long_double_const
{
	public unsafe static void* Invoke(void* a, void* b)
	{
		return (!unchecked(*(double*)a < *(double*)b)) ? a : b;
	}
}
