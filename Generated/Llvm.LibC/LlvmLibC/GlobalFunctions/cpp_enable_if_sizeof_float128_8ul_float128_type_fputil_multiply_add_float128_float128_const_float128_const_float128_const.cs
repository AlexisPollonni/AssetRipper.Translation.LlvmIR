using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil12multiply_addIgEENS_3cpp9enable_ifIXgtstT_Lm8EES4_E4typeERKS4_S8_S8_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__float128) > 8ul), __float128>::type __llvm_libc_20_1_2_::fputil::multiply_add<__float128>(__float128 const&, __float128 const&, __float128 const&)")]
internal static partial class cpp_enable_if_sizeof_float128_8ul_float128_type_fputil_multiply_add_float128_float128_const_float128_const_float128_const
{
	public unsafe static double Invoke(void* x, void* y, void* z)
	{
		return unchecked(llvm_fmuladd_f128.Invoke(*(double*)x, *(double*)y, *(double*)z));
	}
}
