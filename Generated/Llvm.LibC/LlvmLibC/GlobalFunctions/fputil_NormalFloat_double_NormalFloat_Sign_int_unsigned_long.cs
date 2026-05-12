using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIdEC2ENS_4SignEim")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned long)")]
internal static partial class fputil_NormalFloat_double_NormalFloat_Sign_int_unsigned_long
{
	public unsafe static void Invoke(fputil_NormalFloat_n2h9ta* @this, [MangledName("s.coerce")] sbyte s, int e, long m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		anon_izyfb8.val = s;
		@this->exponent = e;
		@this->mantissa = m;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		unchecked
		{
			if ((ulong)@this->mantissa < 4503599627370496uL)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_NormalFloat_double_evaluate_normalization_shift_unsigned_long.Invoke(@this, @this->mantissa);
				@this->mantissa <<= (int)(uint)num;
				@this->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
