using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_double_cmp
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIdE3cmpERKS2_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::cmp(__llvm_libc_20_1_2_::fputil::NormalFloat<double> const&) const")]
	public unsafe static int Invoke(fputil_NormalFloat_vc4yvk* @this, [NativeType("__llvm_libc_20_1_2_::fputil::NormalFloat<double> const&")] fputil_NormalFloat_vc4yvk* other)
	{
		int num = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = InstructionHelper.Select(Sign_is_neg.Invoke(&@this->sign), -1, 1);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &other->sign, 1L, isVolatile: false);
		int result = ((!NotEquals_rpctvi.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? ((@this->exponent <= other->exponent) ? ((@this->exponent != other->exponent) ? (-num) : (unchecked((ulong)@this->mantissa <= (ulong)other->mantissa) ? ((@this->mantissa != other->mantissa) ? (-num) : 0) : num)) : num) : num);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
