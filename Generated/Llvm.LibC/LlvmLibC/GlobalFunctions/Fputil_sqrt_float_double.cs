using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_sqrt_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIfdEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type __llvm_libc_20_1_2_::fputil::sqrt<float, double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<float> && cpp::is_floating_point_v<double> && sizeof (float) <= sizeof (double), float>::type")]
	public unsafe static float Invoke([MangledName("x")][NativeType("double")] double X)
	{
		long num = 0L;
		float num2 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq);
		Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2 = default(Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num3 = 0;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		long num9 = 0L;
		Llvm_libc_20_1_2_fputil_DyadicFloat_syracv llvm_libc_20_1_2_fputil_DyadicFloat_syracv = default(Llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_BigInt_555ggs llvm_libc_20_1_2_BigInt_555ggs = default(Llvm_libc_20_1_2_BigInt_555ggs);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 4503599627370496L;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = float.NaN;
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, X);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 8L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb.Val);
			llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			bool num10 = Internal_Equals_r4buia.Invoke(llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq.FPRepSem.FPStorage.Val, llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.Val) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
			float result;
			if (num10)
			{
				result = Fputil_cast_float_double.Invoke(X);
			}
			else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
			{
				result = float.NaN;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm));
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm)))
				{
					num3 = checked(num3 + 1);
					Internal_normalize_double.Invoke(&num3, &num4);
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
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = 4503599627370496L;
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = num4 - 4503599627370496L;
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				for (num7 = 2251799813685248L; num7 != 0L; num7 >>>= 1)
				{
					num6 <<= 1;
					Llvm_lifetime_start_p0.Invoke(8L, &num8);
					num8 = (num5 << 1) + num7;
					if ((ulong)num6 >= (ulong)num8)
					{
						num6 -= num8;
						num5 += num7;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num8);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				num6 <<= 2;
				num5 <<= 2;
				Llvm_lifetime_start_p0.Invoke(8L, &num9);
				num9 = num5 + 1L;
				if ((ulong)num6 >= (ulong)num9)
				{
					num6 -= num9;
					num5 |= 2L;
				}
				num5 |= ((num6 != 0L) ? 1L : 0L);
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
				*(sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv) = -86;
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv))[1] = -1431655766;
				((long*)(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num3 >> 1) - 2 - 52);
				BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke(&llvm_libc_20_1_2_BigInt_555ggs, num5);
				DyadicFloat_64ul_Constructor.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv, anon_izyfb2.Val, e, *(long*)(&llvm_libc_20_1_2_BigInt_555ggs.Val.Data));
				result = DyadicFloat_64ul_as_float_true_void.Invoke(&llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_DyadicFloat_syracv);
				Llvm_lifetime_end_p0.Invoke(8L, &num9);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(4L, &num3);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
