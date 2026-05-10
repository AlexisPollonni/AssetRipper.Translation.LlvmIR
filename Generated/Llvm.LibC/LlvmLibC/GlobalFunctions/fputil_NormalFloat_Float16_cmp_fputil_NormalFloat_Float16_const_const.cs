using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_E3cmpERKS2_")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::cmp(__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16> const&) const")]
internal static partial class fputil_NormalFloat_Float16_cmp_fputil_NormalFloat_Float16_const_const
{
	public unsafe static int Invoke(void* @this, void* other)
	{
		int num = 0;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		unchecked
		{
			num = InstructionHelper.Select(Sign_is_neg_const.Invoke(&((fputil_NormalFloat_epbrnk*)@this)->sign), -1, 1);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_NormalFloat_epbrnk*)@this)->sign, 1L, isVolatile: false);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &((fputil_NormalFloat_epbrnk*)other)->sign, 1L, isVolatile: false);
			int result = ((!operator_Sign_Sign_rpctvi.Invoke(anon_izyfb8.val, anon_izyfb9.val)) ? ((((fputil_NormalFloat_epbrnk*)@this)->exponent <= ((fputil_NormalFloat_epbrnk*)other)->exponent) ? ((((fputil_NormalFloat_epbrnk*)@this)->exponent != ((fputil_NormalFloat_epbrnk*)other)->exponent) ? checked(-num) : (((ushort)((fputil_NormalFloat_epbrnk*)@this)->mantissa <= (ushort)((fputil_NormalFloat_epbrnk*)other)->mantissa) ? (((ushort)((fputil_NormalFloat_epbrnk*)@this)->mantissa != (ushort)((fputil_NormalFloat_epbrnk*)other)->mantissa) ? checked(-num) : 0) : num)) : num) : num);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
