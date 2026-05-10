using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EcvDF16_Ev")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::operator _Float16() const")]
internal static partial class fputil_NormalFloat_Float16_operator_Float16_const
{
	public unsafe static Half Invoke(void* @this)
	{
		int num = 0;
		int num2 = 0;
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_2fahva fputil_FPBits_2fahva3 = default(fputil_FPBits_2fahva);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		short num5 = 0;
		short num6 = 0;
		short num7 = 0;
		short num8 = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = unchecked((fputil_NormalFloat_epbrnk*)@this)->exponent + 15;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 30;
		unchecked
		{
			Half result;
			if (num > 30)
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_NormalFloat_epbrnk*)@this)->sign, 1L, isVolatile: false);
				short field_ = fputil_internal_FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf_Sign.Invoke(anon_izyfb8.val);
				fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				*(short*)(&fputil_FPBits_2fahva3) = -21846;
				fputil_FPBits_Float16_FPBits_Float16_Float16.Invoke(&fputil_FPBits_2fahva3, default(Half));
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &((fputil_NormalFloat_epbrnk*)@this)->sign, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_0_set_sign_Sign.Invoke(&fputil_FPBits_2fahva3, anon_izyfb9.val);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -14;
				if (((fputil_NormalFloat_epbrnk*)@this)->exponent < -14)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					checked
					{
						num4 = -14 - unchecked((fputil_NormalFloat_epbrnk*)@this)->exponent;
					}
					if ((uint)num4 <= 11u)
					{
						llvm_lifetime_start_p0.Invoke(2L, &num5);
						num5 = (short)checked(unchecked((ushort)(short)(1 << num4)) - 1);
						llvm_lifetime_start_p0.Invoke(2L, &num6);
						num6 = (short)((ushort)((fputil_NormalFloat_epbrnk*)@this)->mantissa & (ushort)num5);
						llvm_lifetime_start_p0.Invoke(2L, &num7);
						num7 = (short)(1 << num4 - 1);
						fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent_unsigned_short.Invoke(&fputil_FPBits_2fahva3, 0);
						fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa_unsigned_short.Invoke(&fputil_FPBits_2fahva3, (short)((ushort)((fputil_NormalFloat_epbrnk*)@this)->mantissa >> num4));
						llvm_lifetime_start_p0.Invoke(2L, &num8);
						num8 = fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke(&fputil_FPBits_2fahva3);
						if ((ushort)num6 > (ushort)num7)
						{
							num8 = (short)checked(unchecked((ushort)num8) + 1);
						}
						else if ((ushort)num6 == (ushort)num7 && ((ushort)fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa_const.Invoke(&fputil_FPBits_2fahva3) & 1) != 0)
						{
							num8 = (short)checked(unchecked((ushort)num8) + 1);
						}
						fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa_unsigned_short.Invoke(&fputil_FPBits_2fahva3, num8);
						if ((ushort)num8 == 1024)
						{
							fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent_unsigned_short.Invoke(&fputil_FPBits_2fahva3, 1);
						}
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
						llvm_lifetime_end_p0.Invoke(2L, &num8);
						llvm_lifetime_end_p0.Invoke(2L, &num7);
						llvm_lifetime_end_p0.Invoke(2L, &num6);
						llvm_lifetime_end_p0.Invoke(2L, &num5);
					}
					else
					{
						result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent_unsigned_short.Invoke(&fputil_FPBits_2fahva3, (short)checked(unchecked((fputil_NormalFloat_epbrnk*)@this)->exponent + 15));
					fputil_internal_FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa_unsigned_short.Invoke(&fputil_FPBits_2fahva3, ((fputil_NormalFloat_epbrnk*)@this)->mantissa);
					result = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva3);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
