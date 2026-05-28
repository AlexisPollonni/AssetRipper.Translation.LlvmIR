using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Fputil_sqrt_Float16_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil4sqrtIDF16_dEENS_3cpp9enable_ifIXaaaasr3cppE19is_floating_point_vIT_Esr3cppE19is_floating_point_vIT0_ElestS4_stS5_ES4_E4typeES5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type __llvm_libc_20_1_2_::fputil::sqrt<_Float16, double>(double)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_floating_point_v<_Float16> && cpp::is_floating_point_v<double> && sizeof (_Float16) <= sizeof (double), _Float16>::type")]
	public unsafe static Half Invoke([MangledName("x")][NativeType("double")] double X)
	{
		long num = 0L;
		Half half = default(Half);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm = default(Fputil_FPBits_wjhbrm);
		Fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq = default(Fputil_internal_FPRepImpl_ucubaq);
		Fputil_internal_FPRepImpl_ucubaq fputil_internal_FPRepImpl_ucubaq2 = default(Fputil_internal_FPRepImpl_ucubaq);
		Fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(Fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		Fputil_DyadicFloat_syracv fputil_DyadicFloat_syracv = default(Fputil_DyadicFloat_syracv);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		BigInt_555ggs bigInt_555ggs = default(BigInt_555ggs);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 4503599627370496L;
		Llvm_lifetime_start_p0.Invoke(2L, &half);
		half = default(Half);
		Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm) = -6148914691236517206L;
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm, X);
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq, &fputil_FPBits_wjhbrm, 8L, isVolatile: false);
			Llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_POS.Pointer, 1L, isVolatile: false);
			long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb.Val);
			fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
			Llvm_memcpy_p0_p0_i64.Invoke(&fputil_internal_FPRepImpl_ucubaq2, &fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
			bool num9 = Internal_Equals_r4buia.Invoke(fputil_internal_FPRepImpl_ucubaq.FPRepSem.FPStorage.Val, fputil_internal_FPRepImpl_ucubaq2.FPRepSem.FPStorage.Val) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_zero.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)) || FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_nan.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm));
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
			Half result;
			if (num9)
			{
				result = Fputil_cast_Float16_double.Invoke(X);
			}
			else if (FPRepImpl_fputil_FPType_2_fputil_FPBits_double_is_neg.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm)))
			{
				result = default(Half);
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_exponent.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm));
				if (FPRepSem_fputil_FPType_2_fputil_FPBits_double_is_subnormal.Invoke((Fputil_internal_FPRepSem_fq8nhg*)(&fputil_FPBits_wjhbrm)))
				{
					num2 = checked(num2 + 1);
					Internal_normalize_double.Invoke(&num2, &num3);
				}
				else
				{
					num3 |= 0x10000000000000L;
				}
				if ((num2 & 1) != 0)
				{
					num2 = checked(num2 + -1);
					num3 <<= 1;
				}
				Llvm_lifetime_start_p0.Invoke(8L, &num4);
				num4 = 4503599627370496L;
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = num3 - 4503599627370496L;
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				for (num6 = 2251799813685248L; num6 != 0L; num6 >>>= 1)
				{
					num5 <<= 1;
					Llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = (num4 << 1) + num6;
					if ((ulong)num5 >= (ulong)num7)
					{
						num5 -= num7;
						num4 += num6;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num7);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				num5 <<= 2;
				num4 <<= 2;
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = num4 + 1L;
				if ((ulong)num5 >= (ulong)num8)
				{
					num5 -= num8;
					num4 |= 2L;
				}
				num4 |= ((num5 != 0L) ? 1L : 0L);
				Llvm_lifetime_start_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
				*(sbyte*)(&fputil_DyadicFloat_syracv) = -86;
				sbyte* ptr = (sbyte*)(&fputil_DyadicFloat_syracv) + 1;
				*ptr = -86;
				ptr[1] = -86;
				ptr[2] = -86;
				((int*)(&fputil_DyadicFloat_syracv))[1] = -1431655766;
				((long*)(&fputil_DyadicFloat_syracv))[1] = -6148914691236517206L;
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Sign_POS.Pointer, 1L, isVolatile: false);
				int e = checked((num2 >> 1) - 2 - 52);
				BigInt_64ul_false_unsigned_long_BigInt_unsigned_long_void.Invoke(&bigInt_555ggs, num4);
				DyadicFloat_64ul_Constructor.Invoke(&fputil_DyadicFloat_syracv, anon_izyfb2.Val, e, *(long*)(&bigInt_555ggs.Val.Data));
				result = DyadicFloat_64ul_as_Float16_true_void.Invoke(&fputil_DyadicFloat_syracv);
				Llvm_lifetime_end_p0.Invoke(16L, &fputil_DyadicFloat_syracv);
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
				Llvm_lifetime_end_p0.Invoke(8L, &num4);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm);
			Llvm_lifetime_end_p0.Invoke(2L, &half);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
