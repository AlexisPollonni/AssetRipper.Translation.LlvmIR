using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEC2ENS_4SignEij")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned int)")]
internal static partial class fputil_NormalFloat_float_NormalFloat_Sign_int_unsigned_int
{
	public unsafe static void Invoke(void* @this, [MangledName("s.coerce")] sbyte s, int e, int m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		anon_izyfb8.val = s;
		unchecked
		{
			((fputil_NormalFloat_i65f6x*)@this)->exponent = e;
			((fputil_NormalFloat_i65f6x*)@this)->mantissa = m;
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_NormalFloat_i65f6x*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			if ((uint)((fputil_NormalFloat_i65f6x*)@this)->mantissa < 8388608u)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_NormalFloat_float_evaluate_normalization_shift_unsigned_int.Invoke(@this, ((fputil_NormalFloat_i65f6x*)@this)->mantissa);
				((fputil_NormalFloat_i65f6x*)@this)->mantissa <<= num;
				((fputil_NormalFloat_i65f6x*)@this)->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
