using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalINS0_11DyadicFloatILm128EEEJS3_S3_S3_S3_S3_S3_EEENS_3cpp9enable_ifIXgtstT_Lm8EES6_E4typeERKS6_SA_DpRKT0_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>) > 8ul), __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>::type __llvm_libc_20_1_2_::fputil::polyeval<__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>) > 8ul), __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>::type")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* Agg_result, [MangledName("x")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* X, [MangledName("a0")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* A0, [MangledName("a")][CleanName("A")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* A_yc74sk, [MangledName("a1")][CleanName("A")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* A_ijazrn, [MangledName("a3")][CleanName("A")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* A_889uw5, [MangledName("a5")][CleanName("A")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* A_79nth8, [MangledName("a7")][CleanName("A")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* A_zvuc8k, [MangledName("a9")][CleanName("A")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4* A_xhsepw)
	{
		Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4 llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd = default(Llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd4);
		Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
		Fputil_polyeval_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul_fputil_DyadicFloat_128ul.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, X, A_yc74sk, A_ijazrn, A_889uw5, A_79nth8, A_zvuc8k, A_xhsepw);
		Fputil_multiply_add_128ul.Invoke(Agg_result, X, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd, A0);
		Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_fputil_DyadicFloat_kt2kd);
	}
}
