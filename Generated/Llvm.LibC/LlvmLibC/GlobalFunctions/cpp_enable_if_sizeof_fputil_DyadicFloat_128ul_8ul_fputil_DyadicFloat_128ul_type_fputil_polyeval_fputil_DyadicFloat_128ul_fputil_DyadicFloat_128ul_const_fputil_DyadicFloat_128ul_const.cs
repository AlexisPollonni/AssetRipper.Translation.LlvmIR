using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalINS0_11DyadicFloatILm128EEEEENS_3cpp9enable_ifIXgtstT_Lm8EES6_E4typeERKS6_SA_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>) > 8ul), __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>::type __llvm_libc_20_1_2_::fputil::polyeval<__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
internal static partial class cpp_enable_if_sizeof_fputil_DyadicFloat_128ul_8ul_fputil_DyadicFloat_128ul_type_fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_const_fputil_DyadicFloat_128ul_const
{
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, fputil_DyadicFloat_kt2kd4* parameter_1, fputil_DyadicFloat_kt2kd4* a0)
	{
		llvm_memcpy_p0_p0_i64.Invoke(agg_result, a0, 24L, isVolatile: false);
	}
}
