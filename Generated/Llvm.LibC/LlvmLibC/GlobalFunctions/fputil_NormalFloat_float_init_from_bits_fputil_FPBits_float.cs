using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil11NormalFloatIfE14init_from_bitsENS0_6FPBitsIfEE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::init_from_bits(__llvm_libc_20_1_2_::fputil::FPBits<float>)")]
internal static partial class fputil_NormalFloat_float_init_from_bits_fputil_FPBits_float
{
	public unsafe static void Invoke(void* @this, [MangledName("bits.coerce")] int bits)
	{
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num = 0;
		fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = bits;
		llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
		anon_izyfb8.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
		unchecked
		{
			llvm_memcpy_p0_p0_i64.Invoke(&((fputil_NormalFloat_i65f6x*)@this)->sign, &anon_izyfb8, 1L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			if (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_is_inf_or_nan_const.Invoke(&fputil_FPBits_5nkvcs2) || fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_zero_const.Invoke(&fputil_FPBits_5nkvcs2))
			{
				((fputil_NormalFloat_i65f6x*)@this)->exponent = 0;
				((fputil_NormalFloat_i65f6x*)@this)->mantissa = 0;
			}
			else if (fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_is_subnormal_const.Invoke(&fputil_FPBits_5nkvcs2))
			{
				llvm_lifetime_start_p0.Invoke(4L, &num);
				num = fputil_NormalFloat_float_evaluate_normalization_shift_unsigned_int.Invoke(@this, fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2));
				((fputil_NormalFloat_i65f6x*)@this)->mantissa = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2) << num;
				((fputil_NormalFloat_i65f6x*)@this)->exponent = -126 - num;
				llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			else
			{
				((fputil_NormalFloat_i65f6x*)@this)->exponent = checked(unchecked((ushort)fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_biased_exponent_const.Invoke(&fputil_FPBits_5nkvcs2)) - 127);
				((fputil_NormalFloat_i65f6x*)@this)->mantissa = 0x800000 | fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke(&fputil_FPBits_5nkvcs2);
			}
		}
	}
}
