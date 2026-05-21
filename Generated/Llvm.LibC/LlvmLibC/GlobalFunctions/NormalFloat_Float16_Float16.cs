using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_Float16_Float16
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIDF16_EcvDF16_Ev")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<_Float16>::operator _Float16() const")]
	public unsafe static Half Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_NormalFloat_epbrnk* This)
	{
		int num = 0;
		int num2 = 0;
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva2 = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		short num5 = 0;
		short num6 = 0;
		short num7 = 0;
		short num8 = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = This->Exponent + 15;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 30;
		unchecked
		{
			Half result;
			if (num > 30)
			{
				Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
				short field_ = FPRepSem_fputil_FPType_0_fputil_FPBits_Float16_inf.Invoke(anon_izyfb.Val);
				llvm_libc_20_1_2_fputil_FPBits_2fahva.FPRepImpl.FPRepSem.FPStorage.field_0 = field_;
				result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
				Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				*(short*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2) = -21846;
				FPBits_Float16_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2, default(Half));
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &This->Sign, 1L, isVolatile: false);
				FPStorage_fputil_FPType_0_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2, anon_izyfb2.Val);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -14;
				if (This->Exponent < -14)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = checked(-14 - This->Exponent);
					if ((uint)num4 <= 11u)
					{
						Llvm_lifetime_start_p0.Invoke(2L, &num5);
						num5 = (short)checked(unchecked((ushort)(short)(1 << num4)) - 1);
						Llvm_lifetime_start_p0.Invoke(2L, &num6);
						num6 = (short)((ushort)This->Mantissa & (ushort)num5);
						Llvm_lifetime_start_p0.Invoke(2L, &num7);
						num7 = (short)(1 << num4 - 1);
						FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2), 0);
						FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2), (short)((ushort)This->Mantissa >> num4));
						Llvm_lifetime_start_p0.Invoke(2L, &num8);
						num8 = FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2));
						if ((ushort)num6 > (ushort)num7)
						{
							num8 = (short)checked(unchecked((ushort)num8) + 1);
						}
						else if ((ushort)num6 == (ushort)num7 && ((ushort)FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2)) & 1) != 0)
						{
							num8 = (short)checked(unchecked((ushort)num8) + 1);
						}
						FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2), num8);
						if ((ushort)num8 == 1024)
						{
							FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2), 1);
						}
						result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
						Llvm_lifetime_end_p0.Invoke(2L, &num8);
						Llvm_lifetime_end_p0.Invoke(2L, &num7);
						Llvm_lifetime_end_p0.Invoke(2L, &num6);
						Llvm_lifetime_end_p0.Invoke(2L, &num5);
					}
					else
					{
						result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2), (short)checked(This->Exponent + 15));
					FPRepImpl_fputil_FPType_0_fputil_FPBits_Float16_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_7z3gh9*)(&llvm_libc_20_1_2_fputil_FPBits_2fahva2), This->Mantissa);
					result = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
