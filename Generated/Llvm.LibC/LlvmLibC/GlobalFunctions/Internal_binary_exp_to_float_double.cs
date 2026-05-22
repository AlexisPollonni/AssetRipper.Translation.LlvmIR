using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_binary_exp_to_float_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal19binary_exp_to_floatIdEENS0_18FloatConvertReturnIT_EENS0_13ExpandedFloatIS3_EEbNS0_14RoundDirectionE")]
	[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double> __llvm_libc_20_1_2_::internal::binary_exp_to_float<double>(__llvm_libc_20_1_2_::internal::ExpandedFloat<double>, bool, __llvm_libc_20_1_2_::internal::RoundDirection)")]
	[return: NativeType("__llvm_libc_20_1_2_::internal::FloatConvertReturn<double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_internal_FloatConvertReturn_g92bm8* Agg_result, [MangledName("init_num.coerce0")] long Init_num, [MangledName("init_num.coerce1")] int Truncated, [MangledName("truncated")] bool Round, [MangledName("round")] int Mantissa)
	{
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		long num = 0L;
		int num2 = 0;
		int num3 = 0;
		int num4 = 0;
		int num5 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		int num6 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		long num7 = 0L;
		long num8 = 0L;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4 = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv) = Init_num;
			((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv))[2] = Truncated;
			sbyte b4 = (Round ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Mantissa;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Exponent;
			*(long*)Agg_result = -6148914691236517206L;
			((int*)Agg_result)[2] = -1431655766;
			sbyte* ptr = (sbyte*)Agg_result + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			((int*)Agg_result)[4] = -1431655766;
			sbyte* ptr2 = (sbyte*)Agg_result + 20;
			*ptr2 = -86;
			ptr2[1] = -86;
			ptr2[2] = -86;
			ptr2[3] = -86;
			FloatConvertReturn_double_Constructor.Invoke(Agg_result);
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = 2047;
			Llvm_lifetime_start_p0.Invoke(4L, &num4);
			num4 = Cpp_countl_zero_unsigned_long.Invoke(num);
			num <<= (int)(uint)num4;
			num2 -= num4;
			Llvm_lifetime_start_p0.Invoke(4L, &num5);
			num5 = checked(num2 + 64 + 1023 - 1);
			if (num5 >= 2047)
			{
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
				llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2.Mantissa = 0L;
				llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2.Exponent = 2047;
				Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv2);
				Agg_result->Error = 34;
				goto IL_04eb;
			}
			Llvm_lifetime_start_p0.Invoke(4L, &num6);
			num6 = 11;
			if (num5 <= 0)
			{
				num6 += checked(1 - num5);
				num5 = 0;
				if ((uint)num6 > 64u)
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3);
					llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3.Mantissa = 0L;
					llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3.Exponent = 0;
					Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3, 16L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv3);
					Agg_result->Error = 34;
					goto IL_04d9;
				}
			}
			Llvm_lifetime_start_p0.Invoke(8L, &num7);
			num7 = 1L << (int)(uint)(num6 - 1);
			Llvm_lifetime_start_p0.Invoke(8L, &num8);
			num8 = num7 - 1L;
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = (((num & num7) != 0L) ? ((sbyte)1) : ((sbyte)0));
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = (((num & num8) != 0L || (b4 & 1) == 1) ? ((sbyte)1) : ((sbyte)0));
			if ((uint)num6 < 64u)
			{
				num >>>= (int)(uint)num6;
				num &= 0xFFFFFFFFFFFFFL;
			}
			else
			{
				num = 0L;
			}
			Llvm_lifetime_start_p0.Invoke(1L, &b3);
			b3 = (((num & 1L) != 0L) ? ((sbyte)1) : ((sbyte)0));
			switch (Mantissa)
			{
			case 2:
				if ((b & 1) == 1 && ((b3 & 1) == 1 || (b2 & 1) == 1))
				{
					num++;
				}
				break;
			case 0:
				if ((b & 1) == 1 || (b2 & 1) == 1)
				{
					num++;
				}
				break;
			default:
				if ((b & 1) == 1 && (b2 & 1) == 1)
				{
					num++;
				}
				break;
			}
			if ((ulong)num > 4503599627370495uL)
			{
				num5 = checked(num5 + 1);
				if (num5 == 2047)
				{
					Agg_result->Error = 34;
				}
			}
			if (num5 == 0)
			{
				Agg_result->Error = 34;
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4);
			llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4.Mantissa = num & 0xFFFFFFFFFFFFFL;
			llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4.Exponent = num5;
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Num, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv4);
			Llvm_lifetime_end_p0.Invoke(1L, &b3);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &num8);
			Llvm_lifetime_end_p0.Invoke(8L, &num7);
			goto IL_04d9;
		}
		IL_04d9:
		Llvm_lifetime_end_p0.Invoke(4L, &num6);
		goto IL_04eb;
		IL_04eb:
		Llvm_lifetime_end_p0.Invoke(4L, &num5);
		Llvm_lifetime_end_p0.Invoke(4L, &num4);
		Llvm_lifetime_end_p0.Invoke(4L, &num3);
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(8L, &num);
	}
}
