using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class fputil_sqrt_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIfdEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type __llvm_libc_20_1_2_::fputil::sqrt<float, double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type")]
	public unsafe static float Invoke([NativeType("double")] double x)
	{
		long num = 0L;
		float num2 = 0f;
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq3 = default(fputil_internal_FPRepImpl_ucubaq);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num3 = 0;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		long num9 = 0L;
		fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv2 = default(fputil_DyadicFloat_syracv);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 4503599627370496L;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = float.NaN;
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2, x);
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb8.val);
			fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
			llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq3, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
			int num10 = (internal_Equals_r4buia.Invoke(fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.val, fputil_internal_FPRepImpl_ucubaq3.FPRepSem.FPStorage.val) ? (-1) : ((!FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2))) ? (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)) ? 1 : 0) : (-1)));
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
			float result;
			if (num10 != 0)
			{
				result = fputil_cast_float_double.Invoke(x);
			}
			else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2)))
			{
				result = float.NaN;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2));
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm2)))
				{
					num3 = checked(num3 + 1);
					internal_normalize_double.Invoke(&num3, &num4);
				}
				else
				{
					num4 |= 0x10000000000000L;
				}
				if ((num3 & 1) != 0)
				{
					num3 = checked(num3 + -1);
					num4 <<= 1;
				}
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = 4503599627370496L;
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = num4 - 4503599627370496L;
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				for (num7 = 2251799813685248L; num7 != 0L; num7 >>>= 1)
				{
					num6 <<= 1;
					llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = (num5 << 1) + num7;
					if ((ulong)num6 >= (ulong)num8)
					{
						num6 -= num8;
						num5 += num7;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num8);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				num6 <<= 2;
				num5 <<= 2;
				llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = num5 + 1L;
				if ((ulong)num6 >= (ulong)num9)
				{
					num6 -= num9;
					num5 |= 2L;
				}
				num5 |= ((num6 != 0L) ? 1L : 0L);
				llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
				*(sbyte*)(&fputil_DyadicFloat_syracv2) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv2) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_syracv2))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_syracv2))[1] = -6148914691236517206L;
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb9, Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num3 >> 1) - 2 - 52);
				BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke(&bigInt_555ggs, num5);
				DyadicFloat_64ul_Constructor.Invoke(&fputil_DyadicFloat_syracv2, anon_izyfb9.val, e, *(long*)(&bigInt_555ggs.val.Data));
				result = DyadicFloat_64ul_as_float_true_void.Invoke(&fputil_DyadicFloat_syracv2);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv2);
				llvm_lifetime_end_p0.Invoke(8L, &num9);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
				llvm_lifetime_end_p0.Invoke(8L, &num4);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
