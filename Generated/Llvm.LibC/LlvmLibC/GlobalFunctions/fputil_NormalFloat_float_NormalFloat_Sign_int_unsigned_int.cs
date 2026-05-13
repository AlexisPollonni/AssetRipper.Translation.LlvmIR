using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfEC2ENS_4SignEij")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::NormalFloat(__llvm_libc_20_1_2_::Sign, int, unsigned int)")]
internal static partial class fputil_NormalFloat_float_NormalFloat_Sign_int_unsigned_int
{
	public unsafe static void Invoke(fputil_NormalFloat_i65f6x* @this, [MangledName("s.coerce")] sbyte s, int e, int m)
	{
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		anon_izyfb8.val = s;
		@this->exponent = e;
		@this->mantissa = m;
		llvm_memcpy_p0_p0_i64.Invoke(&@this->sign, &anon_izyfb8, 1L, isVolatile: false);
		unchecked
		{
			if ((uint)@this->mantissa < 8388608u)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_NormalFloat_float_evaluate_normalization_shift_unsigned_int.Invoke(@this, @this->mantissa);
				@this->mantissa <<= num;
				@this->exponent -= num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
		}
	}
}
