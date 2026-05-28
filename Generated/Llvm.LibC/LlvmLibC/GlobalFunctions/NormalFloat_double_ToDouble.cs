using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_double_ToDouble
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIdEcvdEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::operator double() const")]
	public unsafe static double Invoke([MangledName("this")] Fputil_NormalFloat_vc4yvk* This)
	{
		int num = 0;
		int num2 = 0;
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = This->Exponent + 1023;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 2046;
		unchecked
		{
			double result;
			if (num > 2046)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, &This->Sign, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb.Val);
				fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, 0.0);
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, &This->Sign, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm2, anon_izyfb2.Val);
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -1022;
				if (This->Exponent < -1022)
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = checked(-1022 - This->Exponent);
					if ((uint)num4 <= 53u)
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = (1L << (int)(uint)num4) - 1L;
						Llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = This->Mantissa & num5;
						Llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = 1L << (int)(uint)(num4 - 1);
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), 0L);
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), This->Mantissa >>> (int)(uint)num4);
						Llvm_lifetime_start_p0.Invoke(8L, &num8);
						num8 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
						if ((ulong)num6 > (ulong)num7)
						{
							num8++;
						}
						else if (num6 == num7 && (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)) & 1L) != 0L)
						{
							num8++;
						}
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), num8);
						if (num8 == 4503599627370496L)
						{
							FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), 1L);
						}
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
						Llvm_lifetime_end_p0.Invoke(8L, &num8);
						Llvm_lifetime_end_p0.Invoke(8L, &num7);
						Llvm_lifetime_end_p0.Invoke(8L, &num6);
						Llvm_lifetime_end_p0.Invoke(8L, &num5);
					}
					else
					{
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), checked(This->Exponent + 1023));
					FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), This->Mantissa);
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
