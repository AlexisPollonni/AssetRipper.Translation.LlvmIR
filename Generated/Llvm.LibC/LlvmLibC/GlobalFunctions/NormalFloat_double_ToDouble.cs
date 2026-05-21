using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class NormalFloat_double_ToDouble
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIdEcvdEv")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::operator double() const")]
	public unsafe static double Invoke(fputil_NormalFloat_vc4yvk* @this)
	{
		int num = 0;
		int num2 = 0;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		int num3 = 0;
		int num4 = 0;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = @this->exponent + 1023;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 2046;
		unchecked
		{
			double result;
			if (num > 2046)
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &@this->sign, 1L, isVolatile: false);
				long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb8.val);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
				result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
				FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm3, 0.0);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &@this->sign, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm3, anon_izyfb9.val);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -1022;
				if (@this->exponent < -1022)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = checked(-1022 - @this->exponent);
					if ((uint)num4 <= 53u)
					{
						llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = (1L << (int)(uint)num4) - 1L;
						llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = @this->mantissa & num5;
						llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = 1L << (int)(uint)(num4 - 1);
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3), 0L);
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3), @this->mantissa >>> (int)(uint)num4);
						llvm_lifetime_start_p0.Invoke(8L, &num8);
						num8 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3));
						if ((ulong)num6 > (ulong)num7)
						{
							num8++;
						}
						else if (num6 == num7 && (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3)) & 1L) != 0L)
						{
							num8++;
						}
						FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3), num8);
						if (num8 == 4503599627370496L)
						{
							FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3), 1L);
						}
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_lifetime_end_p0.Invoke(8L, &num8);
						llvm_lifetime_end_p0.Invoke(8L, &num7);
						llvm_lifetime_end_p0.Invoke(8L, &num6);
						llvm_lifetime_end_p0.Invoke(8L, &num5);
					}
					else
					{
						result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3), checked(@this->exponent + 1023));
					FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm3), @this->mantissa);
					result = FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm3);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			return result;
		}
	}
}
