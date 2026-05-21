using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_strtofloatingpoint_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIdEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<double> __llvm_libc_20_1_2_::internal::strtofloatingpoint<double>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<double>")]
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_k826n6* agg_result, [NativeType("char const*")] void* src)
	{
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm2 = default(fputil_FPBits_wjhbrm);
		sbyte b = 0;
		sbyte b2 = 0;
		int error = 0;
		long num = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		int num3 = 0;
		StrToNumResult_wpp2wp strToNumResult_wpp2wp = default(StrToNumResult_wpp2wp);
		internal_ExpandedFloat_k68bhv internal_ExpandedFloat_k68bhv2 = default(internal_ExpandedFloat_k68bhv);
		StrToNumResult_wpp2wp strToNumResult_wpp2wp2 = default(StrToNumResult_wpp2wp);
		StrToNumResult_wpp2wp strToNumResult_wpp2wp3 = default(StrToNumResult_wpp2wp);
		long num4 = 0L;
		long num5 = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm3 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_wjhbrm fputil_FPBits_wjhbrm4 = default(fputil_FPBits_wjhbrm);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		unchecked
		{
			*(long*)(&fputil_FPBits_wjhbrm2) = -6148914691236517206L;
			llvm_memset_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, 0, 8L, isVolatile: false);
			FPBits_double_Constructor.Invoke(&fputil_FPBits_wjhbrm2);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = 0;
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 43;
			llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = (long)internal_first_non_whitespace.Invoke(src, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke()) - (long)src;
			if (((sbyte*)src)[num] == 43 || ((sbyte*)src)[num] == 45)
			{
				b2 = ((sbyte*)src)[num];
				num = checked(num + 1L);
			}
			if (b2 == 45)
			{
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_2_set_sign.Invoke(&fputil_FPBits_wjhbrm2, anon_izyfb8.val);
			}
			if (internal_isdigit_u2vjuj.Invoke(((sbyte*)src)[num]) || ((sbyte*)src)[num] == 46)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 10;
				if (internal_is_float_hex_start.Invoke((byte*)src + num, 46))
				{
					num2 = 16;
					num = checked(num + 2L);
					b = 1;
				}
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = 2;
				switch (fputil_quick_get_round.Invoke())
				{
				case 0:
					num3 = 2;
					break;
				case 2048:
					num3 = ((b2 != 43) ? 1 : 0);
					break;
				case 1024:
					num3 = ((b2 == 43) ? 1 : 0);
					break;
				case 3072:
					num3 = 1;
					break;
				}
				llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_wpp2wp);
				sbyte* ptr = (sbyte*)(&strToNumResult_wpp2wp);
				*(long*)ptr = -6148914691236517206L;
				((int*)ptr)[2] = -1431655766;
				sbyte* ptr2 = ptr + 12;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				((int*)(&strToNumResult_wpp2wp))[4] = -1431655766;
				sbyte* ptr3 = (sbyte*)(&strToNumResult_wpp2wp) + 20;
				*ptr3 = -86;
				ptr3[1] = -86;
				ptr3[2] = -86;
				ptr3[3] = -86;
				((long*)(&strToNumResult_wpp2wp))[3] = -6148914691236517206L;
				internal_ExpandedFloat_k68bhv2.mantissa = 0L;
				internal_ExpandedFloat_k68bhv2.exponent = 0;
				StrToNumResult_internal_ExpandedFloat_double_Constructor.Invoke(&strToNumResult_wpp2wp, *(long*)(&internal_ExpandedFloat_k68bhv2), ((int*)(&internal_ExpandedFloat_k68bhv2))[2]);
				if (num2 == 16)
				{
					llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_wpp2wp2);
					internal_hexadecimal_string_to_float_double.Invoke(&strToNumResult_wpp2wp2, (byte*)src + num, 46, (RoundDirection_b3pcwy)num3);
					llvm_memcpy_p0_p0_i64.Invoke(&strToNumResult_wpp2wp, &strToNumResult_wpp2wp2, 32L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_wpp2wp2);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(32L, &strToNumResult_wpp2wp3);
					internal_decimal_string_to_float_double.Invoke(&strToNumResult_wpp2wp3, (byte*)src + num, 46, (RoundDirection_b3pcwy)num3);
					llvm_memcpy_p0_p0_i64.Invoke(&strToNumResult_wpp2wp, &strToNumResult_wpp2wp3, 32L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_wpp2wp3);
				}
				b = ((strToNumResult_wpp2wp.parsed_len != 0L) ? ((sbyte)1) : ((sbyte)0));
				FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_mantissa.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), strToNumResult_wpp2wp.value.mantissa);
				FPRepImpl_fputil_FPType_2_fputil_FPBits_double_set_biased_exponent.Invoke((fputil_internal_FPRepImpl_ucubaq*)(&fputil_FPBits_wjhbrm2), strToNumResult_wpp2wp.value.exponent);
				long parsed_len = strToNumResult_wpp2wp.parsed_len;
				num = checked(num + parsed_len);
				error = strToNumResult_wpp2wp.error;
				llvm_lifetime_end_p0.Invoke(32L, &strToNumResult_wpp2wp);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			else if (internal_tolower_b2645y.Invoke(((sbyte*)src)[num]) == 110)
			{
				if (internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 1L)]) == ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_nan_string.Value)[1] && internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 2L)]) == ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_nan_string.Value)[2])
				{
					b = 1;
					num = checked(num + 3L);
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = 0L;
					if (((sbyte*)src)[num] == 40)
					{
						llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = num;
						for (num = checked(num + 1L); (!internal_isalnum_eh69hd.Invoke(((sbyte*)src)[num])) ? (((sbyte*)src)[num] == 95) : true; num = checked(num + 1L))
						{
						}
						if (((sbyte*)src)[num] == 41)
						{
							num = checked(num + 1L);
							string_view_Constructor.Invoke(&cpp_string_view2, (byte*)src + (num5 + 1L), num - num5 - 2L);
							num4 = internal_nan_mantissa_from_ncharseq_double.Invoke(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
						}
						else
						{
							num = num5;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num5);
					}
					llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					anon_izyfb9.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
					long val = FPRepSem_fputil_FPType_2_fputil_FPBits_double_quiet_nan.Invoke(v: num4, sign: anon_izyfb9.val);
					fputil_FPBits_wjhbrm3.FPRepImpl.FPRepSem.FPStorage.val = val;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm3, 8L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm3);
					llvm_lifetime_end_p0.Invoke(8L, &num4);
				}
			}
			else if (internal_tolower_b2645y.Invoke(((sbyte*)src)[num]) == 105 && internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 1L)]) == ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[1] && internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 2L)]) == ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[2])
			{
				b = 1;
				llvm_lifetime_start_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				anon_izyfb10.val = FPStorage_fputil_FPType_2_sign.Invoke(&fputil_FPBits_wjhbrm2);
				long val2 = FPRepSem_fputil_FPType_2_fputil_FPBits_double_inf.Invoke(anon_izyfb10.val);
				fputil_FPBits_wjhbrm4.FPRepImpl.FPRepSem.FPStorage.val = val2;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_wjhbrm2, &fputil_FPBits_wjhbrm4, 8L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm4);
				num = ((internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 3L)]) != ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[3] || internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 4L)]) != ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[4] || internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 5L)]) != ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[5] || internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 6L)]) != ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[6] || internal_tolower_b2645y.Invoke(((sbyte*)src)[checked(num + 7L)]) != ((sbyte*)StrToNumResult_double_internal_strtofloatingpoint_double_char_const_inf_string.Value)[7]) ? checked(num + 3L) : checked(num + 8L));
			}
			if ((b & 1) != 1)
			{
				StrToNumResult_double_Constructor.Invoke(agg_result, 0.0, 0L, error);
			}
			else
			{
				internal_set_implicit_bit_double.Invoke(&fputil_FPBits_wjhbrm2);
				StrToNumResult_double_Constructor.Invoke(agg_result, FPBits_double_get_val.Invoke(&fputil_FPBits_wjhbrm2), num, error);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &error);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &fputil_FPBits_wjhbrm2);
		}
	}
}
