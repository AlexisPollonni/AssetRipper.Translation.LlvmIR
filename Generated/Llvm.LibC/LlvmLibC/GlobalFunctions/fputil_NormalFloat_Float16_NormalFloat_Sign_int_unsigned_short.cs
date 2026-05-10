using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EC2ENS_4SignEit")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned short)")]
internal static partial class fputil_NormalFloat_Float16_NormalFloat_Sign_int_unsigned_short
{
	public unsafe static void Invoke(void* @this, [MangledName("s.coerce")] sbyte s, int e, short m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		anon_izyfb8.val = s;
		short mantissa = m;
		unchecked
		{
			((fputil_NormalFloat_epbrnk*)@this)->exponent = e;
			((fputil_NormalFloat_epbrnk*)@this)->mantissa = mantissa;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_NormalFloat_epbrnk*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			if ((ushort)((fputil_NormalFloat_epbrnk*)@this)->mantissa < 1024)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_NormalFloat_Float16_evaluate_normalization_shift_unsigned_short.Invoke(@this, ((fputil_NormalFloat_epbrnk*)@this)->mantissa);
				int num2 = num;
				short* mantissa2 = &((fputil_NormalFloat_epbrnk*)@this)->mantissa;
				*mantissa2 = (short)((ushort)(*mantissa2) << num2);
				((fputil_NormalFloat_epbrnk*)@this)->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
