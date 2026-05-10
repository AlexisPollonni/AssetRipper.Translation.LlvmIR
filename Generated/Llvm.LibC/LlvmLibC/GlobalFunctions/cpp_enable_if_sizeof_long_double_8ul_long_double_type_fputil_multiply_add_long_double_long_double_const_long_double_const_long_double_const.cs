using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIeEENS_3cpp9enable_ifIXgtstT_Lm8EES4_E4typeERKS4_S8_S8_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (long double) > 8ul), long double>::type __llvm_libc_20_1_2_::fputil::multiply_add<long double>(long double const&, long double const&, long double const&)")]
internal static partial class cpp_enable_if_sizeof_long_double_8ul_long_double_type_fputil_multiply_add_long_double_long_double_const_long_double_const_long_double_const
{
	public unsafe static double Invoke(void* x, void* y, void* z)
	{
		return unchecked(llvm_fmuladd_f80.Invoke(*(double*)x, *(double*)y, *(double*)z));
	}
}
