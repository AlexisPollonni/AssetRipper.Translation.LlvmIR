using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIfE3cmpERKS2_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::cmp(__llvm_libc_20_1_2_::fputil::NormalFloat<float> const&) const")]
internal static partial class fputil_NormalFloat_float_cmp_fputil_NormalFloat_float_const_const
{
	public unsafe static int Invoke(fputil_NormalFloat_i65f6x* @this, fputil_NormalFloat_i65f6x* other)
	{
		int num = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = InstructionHelper.Select(Sign_is_neg_const.Invoke(&@this->sign), -1, 1);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
		llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &other->sign, 1L, isVolatile: false);
		int result = ((!operator_Sign_Sign_rpctvi.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? ((@this->exponent <= other->exponent) ? ((@this->exponent != other->exponent) ? (-num) : (unchecked((uint)@this->mantissa <= (uint)other->mantissa) ? ((@this->mantissa != other->mantissa) ? (-num) : 0) : num)) : num) : num);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		return result;
	}
}
