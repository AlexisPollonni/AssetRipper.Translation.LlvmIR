using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIfEcvfEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<float>::operator float() const")]
internal static partial class fputil_NormalFloat_float_operator_float_const
{
	public unsafe static float Invoke(fputil_NormalFloat_i65f6x* @this)
	{
		int num = 0;
		int num2 = 0;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		int num6 = 0;
		int num7 = 0;
		int num8 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = @this->exponent + 127;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 254;
		unchecked
		{
			float result;
			if (num > 254)
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
				int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb8.val);
				fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
				result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				*(int*)(&fputil_FPBits_5nkvcs3) = -1431655766;
				fputil_FPBits_float_FPBits_float_float.Invoke(&fputil_FPBits_5nkvcs3, 0f);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &@this->sign, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs3, anon_izyfb9.val);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -126;
				if (@this->exponent < -126)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = checked(-126 - @this->exponent);
					if ((uint)num4 <= 24u)
					{
						llvm_lifetime_start_p0.Invoke(4L, &num5);
						num5 = (1 << num4) - 1;
						llvm_lifetime_start_p0.Invoke(4L, &num6);
						num6 = @this->mantissa & num5;
						llvm_lifetime_start_p0.Invoke(4L, &num7);
						num7 = 1 << num4 - 1;
						fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3), 0);
						fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3), @this->mantissa >>> num4);
						llvm_lifetime_start_p0.Invoke(4L, &num8);
						num8 = fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3));
						if ((uint)num6 > (uint)num7)
						{
							num8++;
						}
						else if (num6 == num7 && (fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_get_mantissa_const.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3)) & 1) != 0)
						{
							num8++;
						}
						fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3), num8);
						if (num8 == 8388608)
						{
							fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3), 1);
						}
						result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
						llvm_lifetime_end_p0.Invoke(4L, &num8);
						llvm_lifetime_end_p0.Invoke(4L, &num7);
						llvm_lifetime_end_p0.Invoke(4L, &num6);
						llvm_lifetime_end_p0.Invoke(4L, &num5);
					}
					else
					{
						result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3), checked(@this->exponent + 127));
					fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs3), @this->mantissa);
					result = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs3);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
