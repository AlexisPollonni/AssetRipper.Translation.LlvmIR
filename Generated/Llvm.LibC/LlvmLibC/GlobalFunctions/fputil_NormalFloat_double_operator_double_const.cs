using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil11NormalFloatIdEcvdEv")]
[DemangledName("__llvm_libc_20_1_2_::fputil::NormalFloat<double>::operator double() const")]
internal static partial class fputil_NormalFloat_double_operator_double_const
{
	public unsafe static double Invoke(void* @this)
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
		num = unchecked((fputil_NormalFloat_n2h9ta*)@this)->exponent + 1023;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 2046;
		unchecked
		{
			double result;
			if (num > 2046)
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, &((fputil_NormalFloat_n2h9ta*)@this)->sign, 1L, isVolatile: false);
				long val = fputil_internal_FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf_Sign.Invoke(anon_izyfb8.val);
				fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.val = val;
				result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm2);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
				*(long*)(&fputil_FPBits_wjhbrm3) = -6148914691236517206L;
				fputil_FPBits_double_FPBits_double_double.Invoke(&fputil_FPBits_wjhbrm3, 0.0);
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, &((fputil_NormalFloat_n2h9ta*)@this)->sign, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_2_set_sign_Sign.Invoke(&fputil_FPBits_wjhbrm3, anon_izyfb9.val);
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = -1022;
				if (((fputil_NormalFloat_n2h9ta*)@this)->exponent < -1022)
				{
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					checked
					{
						num4 = -1022 - unchecked((fputil_NormalFloat_n2h9ta*)@this)->exponent;
					}
					if ((uint)num4 <= 53u)
					{
						llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = (1L << (int)(uint)num4) - 1L;
						llvm_lifetime_start_p0.Invoke(8L, &num6);
						num6 = ((fputil_NormalFloat_n2h9ta*)@this)->mantissa & num5;
						llvm_lifetime_start_p0.Invoke(8L, &num7);
						num7 = 1L << (int)(uint)(num4 - 1);
						fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, 0L);
						fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, ((fputil_NormalFloat_n2h9ta*)@this)->mantissa >>> (int)(uint)num4);
						llvm_lifetime_start_p0.Invoke(8L, &num8);
						num8 = fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm3);
						if ((ulong)num6 > (ulong)num7)
						{
							num8++;
						}
						else if (num6 == num7 && (fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa_const.Invoke(&fputil_FPBits_wjhbrm3) & 1L) != 0L)
						{
							num8++;
						}
						fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, num8);
						if (num8 == 4503599627370496L)
						{
							fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, 1L);
						}
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
						llvm_lifetime_end_p0.Invoke(8L, &num8);
						llvm_lifetime_end_p0.Invoke(8L, &num7);
						llvm_lifetime_end_p0.Invoke(8L, &num6);
						llvm_lifetime_end_p0.Invoke(8L, &num5);
					}
					else
					{
						result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
					}
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
				else
				{
					checked
					{
						fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, unchecked((fputil_NormalFloat_n2h9ta*)@this)->exponent + 1023);
					}
					fputil_internal_FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa_unsigned_long.Invoke(&fputil_FPBits_wjhbrm3, ((fputil_NormalFloat_n2h9ta*)@this)->mantissa);
					result = fputil_FPBits_double_get_val_const.Invoke(&fputil_FPBits_wjhbrm3);
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
