using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strtofloatingpoint_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIdEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double> __llvm_libc_20_1_2_::internal::strtofloatingpoint<double>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_StrToNumResult_k826n6* Agg_result, [MangledName("src")][NativeType("char const*")] void* Src)
	{
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		sbyte b = 0;
		sbyte b2 = 0;
		int error = 0;
		long num = 0L;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num2 = 0;
		int round = 0;
		Llvm_libc_20_1_2_StrToNumResult_wpp2wp llvm_libc_20_1_2_StrToNumResult_wpp2wp = default(Llvm_libc_20_1_2_StrToNumResult_wpp2wp);
		Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv = default(Llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv);
		Llvm_libc_20_1_2_StrToNumResult_wpp2wp llvm_libc_20_1_2_StrToNumResult_wpp2wp2 = default(Llvm_libc_20_1_2_StrToNumResult_wpp2wp);
		Llvm_libc_20_1_2_StrToNumResult_wpp2wp llvm_libc_20_1_2_StrToNumResult_wpp2wp3 = default(Llvm_libc_20_1_2_StrToNumResult_wpp2wp);
		long num3 = 0L;
		long num4 = 0L;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm2 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Llvm_libc_20_1_2_fputil_FPBits_wjhbrm llvm_libc_20_1_2_fputil_FPBits_wjhbrm3 = default(Llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		unchecked
		{
			*(long*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm) = -6148914691236517206L;
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, 0, 8L, isVolatile: false);
			FPBits_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
			Llvm_lifetime_start_p0.Invoke(1L, &b);
			b = 0;
			Llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 43;
			Llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = (long)Internal_first_non_whitespace.Invoke(Src, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke()) - (long)Src;
			if (((sbyte*)Src)[num] == 43 || ((sbyte*)Src)[num] == 45)
			{
				b2 = ((sbyte*)Src)[num];
				num = checked(num + 1L);
			}
			if (b2 == 45)
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Llvm_libc_20_1_2_Sign_NEG.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, anon_izyfb.Val);
			}
			if (Internal_isdigit_u2vjuj.Invoke(((sbyte*)Src)[num]) || ((sbyte*)Src)[num] == 46)
			{
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 10;
				if (Internal_is_float_hex_start.Invoke((byte*)Src + num, 46))
				{
					num2 = 16;
					num = checked(num + 2L);
					b = 1;
				}
				Llvm_lifetime_start_p0.Invoke(4L, &round);
				round = 2;
				switch (Fputil_quick_get_round.Invoke())
				{
				case 0:
					round = 2;
					break;
				case 2048:
					round = ((b2 != 43) ? 1 : 0);
					break;
				case 1024:
					round = ((b2 == 43) ? 1 : 0);
					break;
				case 3072:
					round = 1;
					break;
				}
				Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_wpp2wp);
				sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_wpp2wp);
				*(long*)ptr = -6148914691236517206L;
				((int*)ptr)[2] = -1431655766;
				sbyte* ptr2 = ptr + 12;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				((int*)(&llvm_libc_20_1_2_StrToNumResult_wpp2wp))[4] = -1431655766;
				sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_StrToNumResult_wpp2wp) + 20;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				ptr3[3] = -86;
				((long*)(&llvm_libc_20_1_2_StrToNumResult_wpp2wp))[3] = -6148914691236517206L;
				llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Mantissa = 0L;
				llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv.Exponent = 0;
				StrToNumResult_internal_ExpandedFloat_double_Constructor.Invoke(&llvm_libc_20_1_2_StrToNumResult_wpp2wp, *(long*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv), ((int*)(&llvm_libc_20_1_2_internal_ExpandedFloat_k68bhv))[2]);
				if (num2 == 16)
				{
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_wpp2wp2);
					Internal_hexadecimal_string_to_float_double.Invoke(&llvm_libc_20_1_2_StrToNumResult_wpp2wp2, (byte*)Src + num, 46, (RoundDirection_b3pcwy)round);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_StrToNumResult_wpp2wp, &llvm_libc_20_1_2_StrToNumResult_wpp2wp2, 32L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_wpp2wp2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_wpp2wp3);
					Internal_decimal_string_to_float_double.Invoke(&llvm_libc_20_1_2_StrToNumResult_wpp2wp3, (byte*)Src + num, 46, (RoundDirection_b3pcwy)round);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_StrToNumResult_wpp2wp, &llvm_libc_20_1_2_StrToNumResult_wpp2wp3, 32L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_wpp2wp3);
				}
				b = ((llvm_libc_20_1_2_StrToNumResult_wpp2wp.Parsed_len != 0L) ? ((sbyte)1) : ((sbyte)0));
				FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm), llvm_libc_20_1_2_StrToNumResult_wpp2wp.Value.Mantissa);
				FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((Llvm_libc_20_1_2_fputil_internal_FPRepImpl_ucubaq*)(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm), llvm_libc_20_1_2_StrToNumResult_wpp2wp.Value.Exponent);
				long parsed_len = llvm_libc_20_1_2_StrToNumResult_wpp2wp.Parsed_len;
				num = checked(num + parsed_len);
				error = llvm_libc_20_1_2_StrToNumResult_wpp2wp.Error;
				Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_StrToNumResult_wpp2wp);
				Llvm_lifetime_end_p0.Invoke(4L, &round);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			else if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num]) == 110)
			{
				if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 1L)]) == ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_nan_string.Value)[1] && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 2L)]) == ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_nan_string.Value)[2])
				{
					b = 1;
					num = checked(num + 3L);
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = 0L;
					if (((sbyte*)Src)[num] == 40)
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = num;
						for (num = checked(num + 1L); (!Internal_isalnum_eh69hd.Invoke(((sbyte*)Src)[num])) ? (((sbyte*)Src)[num] == 95) : true; num = checked(num + 1L))
						{
						}
						if (((sbyte*)Src)[num] == 41)
						{
							num = checked(num + 1L);
							String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, (byte*)Src + (num4 + 1L), num - num4 - 2L);
							num3 = Internal_nan_mantissa_from_ncharseq_double.Invoke(*(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]);
						}
						else
						{
							num = num4;
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num4);
					}
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					anon_izyfb2.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(V: num3, Sign: anon_izyfb2.Val);
					llvm_libc_20_1_2_fputil_FPBits_wjhbrm2.FPRepImpl.FPRepSem.FPStorage.Val = val;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2, 8L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm2);
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
				}
			}
			else if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num]) == 105 && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 1L)]) == ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[1] && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 2L)]) == ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[2])
			{
				b = 1;
				Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				anon_izyfb3.Val = FPStorage_fputil_FPType_2_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb3.Val);
				llvm_libc_20_1_2_fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.Val = val2;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm3);
				num = ((Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 3L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[3] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 4L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[4] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 5L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[5] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 6L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[6] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 7L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[7]) ? checked(num + 3L) : checked(num + 8L));
			}
			if ((b & 1) != 1)
			{
				StrToNumResult_double_Constructor.Invoke(Agg_result, 0.0, 0L, error);
			}
			else
			{
				Internal_set_implicit_bit_double.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
				StrToNumResult_double_Constructor.Invoke(Agg_result, FPBits_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_wjhbrm), num, error);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &error);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_fputil_FPBits_wjhbrm);
		}
	}
}
