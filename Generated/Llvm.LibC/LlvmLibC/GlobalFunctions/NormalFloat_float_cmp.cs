using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_float_cmp
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIfE3cmpERKS2_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::cmp(__llvm_libc_20_1_2_::fputil::NormalFloat<float> const&) const")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv* This, [MangledName("other")][NativeType("__llvm_libc_20_1_2_::fputil::NormalFloat<float> const&")] Llvm_libc_20_1_2_fputil_NormalFloat_phu2qv* Other)
	{
		int num = 0;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = InstructionHelper.Select(Sign_is_neg.Invoke(&This->Sign), -1, 1);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
		Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &Other->Sign, 1L, isVolatile: false);
		int result = ((!Llvm_libc_20_1_2_NotEquals_rpctvi.Invoke(anon_izyfb.Val, anon_izyfb2.Val)) ? ((This->Exponent <= Other->Exponent) ? ((This->Exponent != Other->Exponent) ? (-num) : (unchecked((uint)This->Mantissa <= (uint)Other->Mantissa) ? ((This->Mantissa != Other->Mantissa) ? (-num) : 0) : num)) : num) : num);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
