using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_polyeval_fputil_DyadicFloat_128ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8polyevalINS0_11DyadicFloatILm128EEEEENS_3cpp9enable_ifIXgtstT_Lm8EES6_E4typeERKS6_SA_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>) > 8ul), __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>::type __llvm_libc_20_1_2_::fputil::polyeval<__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>(__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&, __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<(sizeof (__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>) > 8ul), __llvm_libc_20_1_2_::fputil::DyadicFloat<128ul>>::type")]
	public unsafe static void Invoke([MangledName("agg.result")] Fputil_DyadicFloat_kt2kd4* Agg_result, [NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* parameter_1, [MangledName("a0")][NativeType("__llvm_libc_20_1_2_::fputil::DyadicFloat<128ul> const&")] Fputil_DyadicFloat_kt2kd4* A0)
	{
		Llvm_memcpy_p0_p0_i64.Invoke(Agg_result, A0, 24L, isVolatile: false);
	}
}
