using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class FMod_double_unsigned_long_fputil_generic_FModDivisionSimpleHelper_unsigned_long_eval_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil7generic4FModIdmNS1_24FModDivisionSimpleHelperImEEE13eval_internalENS0_6FPBitsIdEES7_")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::generic::FMod<double, unsigned long, __llvm_libc_20_1_2_::fputil::generic::FModDivisionSimpleHelper<unsigned long>>::eval_internal(__llvm_libc_20_1_2_::fputil::FPBits<double>, __llvm_libc_20_1_2_::fputil::FPBits<double>)")]
	public unsafe static long Invoke([MangledName("sx.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long Sx, [MangledName("sy.coerce")][NativeType("__llvm_libc_20_1_2_::fputil::FPBits<double>")] long Sy)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		long num6 = 0L;
		long num7 = 0L;
		int num8 = 0;
		int num9 = 0;
		int num10 = 0;
		int sides_zeroes_count = 0;
		int num11 = 0;
		int num12 = 0;
		int num13 = 0;
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = Sx;
		llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = Sy;
		unchecked
		{
			if (Details_expects_bool_condition_bool.Invoke((ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)) <= (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)), Expected: true))
			{
				if ((ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)) < (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3)))
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
				}
				else
				{
					Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val;
				}
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num);
				num = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (ushort)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
				if (Details_expects_bool_condition_bool.Invoke(num2 > 52 && checked(num - num2) <= 11, Expected: true))
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
					Llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
					Llvm_lifetime_start_p0.Invoke(8L, &num5);
					num5 = ((num != num2) ? ((long)((ulong)(num3 << (int)(uint)checked(num - num2)) % (ulong)num4)) : (num3 - num4));
					if (num5 == 0L)
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb2, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb2.Val);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val2;
					}
					else
					{
						long val3 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_make_value.Invoke(num5, checked(num2 - 1));
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val3;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num5);
					Llvm_lifetime_end_p0.Invoke(8L, &num4);
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
				else if (Details_expects_bool_condition_bool.Invoke(num == 0 && num2 == 0, Expected: false))
				{
					*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
					FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm), (long)((ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2)) % (ulong)FPRepImpl_fputil_FPType_2_fputil_FPBits_double_uintval.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3))));
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num6);
					num6 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm2));
					num = checked(num + -1);
					Llvm_lifetime_start_p0.Invoke(8L, &num7);
					num7 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_get_explicit_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepSem_fq8nhg*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
					Llvm_lifetime_start_p0.Invoke(4L, &num8);
					num8 = 11;
					Llvm_lifetime_start_p0.Invoke(4L, &num9);
					num9 = 11;
					if (Details_expects_bool_condition_bool.Invoke(num2 > 0, Expected: true))
					{
						num2 = checked(num2 + -1);
					}
					else
					{
						num7 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_get_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm3));
						num9 = Cpp_countl_zero_unsigned_long.Invoke(num7);
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num10);
					num10 = Cpp_countr_zero_unsigned_long.Invoke(num7);
					Llvm_lifetime_start_p0.Invoke(4L, &sides_zeroes_count);
					checked
					{
						sides_zeroes_count = num9 + num10;
						Llvm_lifetime_start_p0.Invoke(4L, &num11);
						num11 = num - num2;
						Llvm_lifetime_start_p0.Invoke(4L, &num12);
						num12 = ((num11 >= num10) ? num10 : num11);
						num7 >>>= unchecked((int)(uint)num12);
						num11 -= num12;
						num2 += num12;
						Llvm_lifetime_end_p0.Invoke(4L, &num12);
						Llvm_lifetime_start_p0.Invoke(4L, &num13);
						num13 = ((num11 >= 11) ? 11 : num11);
						num6 <<= unchecked((int)(uint)num13);
						num11 -= num13;
						Llvm_lifetime_end_p0.Invoke(4L, &num13);
					}
					num6 = (long)((ulong)num6 % (ulong)num7);
					if (Details_expects_bool_condition_bool.Invoke(num6 == 0L, Expected: false))
					{
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb3, Llvm_libc_20_1_2_Sign_POS.Pointer, 1L, isVolatile: false);
						long val4 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_zero.Invoke(anon_izyfb3.Val);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val4;
					}
					else if (num11 == 0)
					{
						long val5 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_make_value.Invoke(num6, num2);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val5;
					}
					else
					{
						num6 = FModDivisionSimpleHelper_unsigned_long_execute.Invoke(num11, sides_zeroes_count, num6, num7);
						long val6 = FPRepImpl_fputil_FPType_2_fputil_FPBits_double_make_value.Invoke(num6, num2);
						llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val = val6;
					}
					Llvm_lifetime_end_p0.Invoke(4L, &num11);
					Llvm_lifetime_end_p0.Invoke(4L, &sides_zeroes_count);
					Llvm_lifetime_end_p0.Invoke(4L, &num10);
					Llvm_lifetime_end_p0.Invoke(4L, &num9);
					Llvm_lifetime_end_p0.Invoke(4L, &num8);
					Llvm_lifetime_end_p0.Invoke(8L, &num7);
					Llvm_lifetime_end_p0.Invoke(8L, &num6);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(4L, &num);
			}
			return llvm_libc_20_1_2_fputil_FPBits_wjhbrm.FPRepImpl.FPRepSem.FPStorage.Val;
		}
	}
}
