using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalINS_10NumberPairIdEEEENS_3cpp9enable_ifIXgtstT_Lm8EES6_E4typeERKS6_SA_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::NumberPair<double>) > 8ul), __llvm_libc_20_1_2_::NumberPair<double>>::type __llvm_libc_20_1_2_::fputil::polyeval<__llvm_libc_20_1_2_::NumberPair<double>>(__llvm_libc_20_1_2_::NumberPair<double> const&, __llvm_libc_20_1_2_::NumberPair<double> const&)")]
internal static partial class cpp_enable_if_sizeof_NumberPair_double_8ul_NumberPair_double_type_fputil_polyeval_NumberPair_double_NumberPair_double_const_NumberPair_double_const
{
	public unsafe static Struct_4ydhja Invoke(void* parameter_0, void* a0)
	{
		NumberPair numberPair = default(NumberPair);
		llvm_memcpy_p0_p0_i64.Invoke(&numberPair, a0, 16L, isVolatile: false);
		return *unchecked((Struct_4ydhja*)(&numberPair));
	}
}
