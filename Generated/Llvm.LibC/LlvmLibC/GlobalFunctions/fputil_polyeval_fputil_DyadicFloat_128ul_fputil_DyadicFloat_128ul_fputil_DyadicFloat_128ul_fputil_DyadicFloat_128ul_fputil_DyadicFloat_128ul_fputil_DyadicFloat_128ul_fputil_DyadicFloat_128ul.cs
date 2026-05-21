using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalINS0_11DyadicFloatILm128EEEJS3_S3_S3_S3_S3_S3_EEENS_3cpp9enable_ifIXgtstT_Lm8EES6_E4typeERKS6_SA_DpRKT0_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>) > 8ul), __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>::type __llvm_libc_20_1_2_::fputil::polyeval<__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>) > 8ul), __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>::type")]
	public unsafe static void Invoke([MangledName("agg.result")] fputil_DyadicFloat_kt2kd4* agg_result, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* x, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* a0, [MangledName("a")][CleanName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* a_yc74sk, [MangledName("a1")][CleanName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* a_ijazrn, [MangledName("a3")][CleanName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* a_889uw5, [MangledName("a5")][CleanName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* a_79nth8, [MangledName("a7")][CleanName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* a_zvuc8k, [MangledName("a9")][CleanName("a")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] fputil_DyadicFloat_kt2kd4* a_xhsepw)
	{
		fputil_DyadicFloat_kt2kd4 fputil_DyadicFloat_kt2kd5 = default(fputil_DyadicFloat_kt2kd4);
		llvm_lifetime_start_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
		fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&fputil_DyadicFloat_kt2kd5, x, a_yc74sk, a_ijazrn, a_889uw5, a_79nth8, a_zvuc8k, a_xhsepw);
		fputil_multiply_add_128ul.Invoke(agg_result, x, &fputil_DyadicFloat_kt2kd5, a0);
		llvm_lifetime_end_p0.Invoke(24L, &fputil_DyadicFloat_kt2kd5);
	}
}
