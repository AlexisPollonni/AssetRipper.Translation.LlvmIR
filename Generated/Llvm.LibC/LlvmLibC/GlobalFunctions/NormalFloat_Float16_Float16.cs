using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_Float16
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EcvDF16_Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::operator _Float16() const")]
	public unsafe static Half Invoke(fputil_NormalFloat_epbrnk* @this)
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
		num = @this->exponent + 15;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 30;
		unchecked
		{
			Half result;
			if (num > 30)
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb8.val);
				fputil_FPBits_2fahva2.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
				llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva3);
				*(short*)(&fputil_FPBits_2fahva3) = -21846;
				FPBits_Float16_Constructor.Invoke(&fputil_FPBits_2fahva3, default(Half));
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &@this->sign, 1L, isVolatile: false);
				FPStorage_fputil_FPType_0_set_sign.Invoke(&fputil_FPBits_2fahva3, anon_izyfb9.val);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -14;
				if (@this->exponent < -14)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = checked(-14 - @this->exponent);
					if ((uint)num4 <= 11u)
					{
						llvm_lifetime_start_p0.Invoke(2L, &num5);
						num5 = (short)checked(unchecked((ushort)(short)(1 << num4)) - 1);
						llvm_lifetime_start_p0.Invoke(2L, &num6);
						num6 = (short)((ushort)@this->mantissa & (ushort)num5);
						llvm_lifetime_start_p0.Invoke(2L, &num7);
						num7 = (short)(1 << num4 - 1);
						FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3), 0);
						FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3), (short)((ushort)@this->mantissa >> num4));
						llvm_lifetime_start_p0.Invoke(2L, &num8);
						num8 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3));
						if ((ushort)num6 > (ushort)num7)
						{
							num8 = (short)checked(unchecked((ushort)num8) + 1);
						}
						else if ((ushort)num6 == (ushort)num7 && ((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3)) & 1) != 0)
						{
							num8 = (short)checked(unchecked((ushort)num8) + 1);
						}
						FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3), num8);
						if ((ushort)num8 == 1024)
						{
							FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3), 1);
						}
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
						llvm_lifetime_end_p0.Invoke(2L, &num8);
						llvm_lifetime_end_p0.Invoke(2L, &num7);
						llvm_lifetime_end_p0.Invoke(2L, &num6);
						llvm_lifetime_end_p0.Invoke(2L, &num5);
					}
					else
					{
						result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3), (short)checked(@this->exponent + 15));
					FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa.Invoke((fputil_internal_FPRepImpl_7z3gh9*)(&fputil_FPBits_2fahva3), @this->mantissa);
					result = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva3);
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
