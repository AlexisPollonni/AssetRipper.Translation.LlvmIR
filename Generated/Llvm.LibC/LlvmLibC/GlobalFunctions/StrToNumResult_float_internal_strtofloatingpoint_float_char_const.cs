using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIfEENS_14StrToNumResultIT_EEPKc")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float> __llvm_libc_20_1_2_::internal::strtofloatingpoint<float>(char const*)")]
internal static partial class StrToNumResult_float_internal_strtofloatingpoint_float_char_const
{
	public unsafe static Struct_fiz2nb Invoke(void* src)
	{
		StrToNumResult_jptppf strToNumResult_jptppf = default(StrToNumResult_jptppf);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		sbyte b = 0;
		sbyte b2 = 0;
		int error = 0;
		long num = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		int num3 = 0;
		StrToNumResult_kkgahp strToNumResult_kkgahp = default(StrToNumResult_kkgahp);
		internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up2 = default(internal_ExpandedFloat_i7t5up);
		StrToNumResult_kkgahp strToNumResult_kkgahp2 = default(StrToNumResult_kkgahp);
		StrToNumResult_kkgahp strToNumResult_kkgahp3 = default(StrToNumResult_kkgahp);
		int num4 = 0;
		long num5 = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs4 = default(fputil_FPBits_5nkvcs);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs2) = -1431655766;
			llvm_memset_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, 0, 4L, isVolatile: false);
			fputil_FPBits_float_FPBits.Invoke(&fputil_FPBits_5nkvcs2);
			llvm_lifetime_start_p0.Invoke(1L, &b);
			b = 0;
			llvm_lifetime_start_p0.Invoke(1L, &b2);
			b2 = 43;
			llvm_lifetime_start_p0.Invoke(4L, &error);
			error = 0;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = (long)internal_first_non_whitespace_char_const_unsigned_long.Invoke(src, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke()) - (long)src;
			if (((sbyte*)src)[num] == 43 || ((sbyte*)src)[num] == 45)
			{
				b2 = ((sbyte*)src)[num];
				num = checked(num + 1L);
			}
			if (b2 == 45)
			{
				llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb8, Sign_NEG.Pointer, 1L, isVolatile: false);
				fputil_internal_FPStorage_fputil_FPType_1_set_sign_Sign.Invoke(&fputil_FPBits_5nkvcs2, anon_izyfb8.val);
			}
			if (internal_isdigit_int_121.Invoke(((sbyte*)src)[num]) || ((sbyte*)src)[num] == 46)
			{
				llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = 10;
				if (internal_is_float_hex_start_char_const_char.Invoke((byte*)src + num, 46))
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
				llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_kkgahp);
				sbyte* ptr = (sbyte*)(&strToNumResult_kkgahp);
				*(int*)ptr = -1431655766;
				((int*)ptr)[1] = -1431655766;
				((int*)(&strToNumResult_kkgahp))[2] = -1431655766;
				sbyte* ptr2 = (sbyte*)(&strToNumResult_kkgahp) + 12;
				*ptr2 = -86;
				ptr2[1] = -86;
				ptr2[2] = -86;
				ptr2[3] = -86;
				((long*)(&strToNumResult_kkgahp))[2] = -6148914691236517206L;
				internal_ExpandedFloat_i7t5up2.mantissa = 0;
				internal_ExpandedFloat_i7t5up2.exponent = 0;
				StrToNumResult_internal_ExpandedFloat_float_StrToNumResult_internal_ExpandedFloat_float.Invoke(&strToNumResult_kkgahp, *(long*)(&internal_ExpandedFloat_i7t5up2));
				if (num2 == 16)
				{
					llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_kkgahp2);
					StrToNumResult_internal_ExpandedFloat_float_internal_hexadecimal_string_to_float_float_char_const_char_internal_RoundDirection.Invoke(&strToNumResult_kkgahp2, (byte*)src + num, 46, (RoundDirection_b3pcwy)num3);
					llvm_memcpy_p0_p0_i64.Invoke(&strToNumResult_kkgahp, &strToNumResult_kkgahp2, 24L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_kkgahp2);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_kkgahp3);
					StrToNumResult_internal_ExpandedFloat_float_internal_decimal_string_to_float_float_char_const_char_internal_RoundDirection.Invoke(&strToNumResult_kkgahp3, (byte*)src + num, 46, (RoundDirection_b3pcwy)num3);
					llvm_memcpy_p0_p0_i64.Invoke(&strToNumResult_kkgahp, &strToNumResult_kkgahp3, 24L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_kkgahp3);
				}
				b = ((strToNumResult_kkgahp.parsed_len != 0L) ? ((sbyte)1) : ((sbyte)0));
				fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2), strToNumResult_kkgahp.value.mantissa);
				fputil_internal_FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent_unsigned_int.Invoke((fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs2), strToNumResult_kkgahp.value.exponent);
				long parsed_len = strToNumResult_kkgahp.parsed_len;
				num = checked(num + parsed_len);
				error = strToNumResult_kkgahp.error;
				llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_kkgahp);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			else if (internal_tolower_int_118.Invoke(((sbyte*)src)[num]) == 110)
			{
				if (internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 1L)]) == ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_nan_string.Value)[1] && internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 2L)]) == ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_nan_string.Value)[2])
				{
					b = 1;
					num = checked(num + 3L);
					llvm_lifetime_start_p0.Invoke(4L, &num4);
					num4 = 0;
					if (((sbyte*)src)[num] == 40)
					{
						llvm_lifetime_start_p0.Invoke(8L, &num5);
						num5 = num;
						for (num = checked(num + 1L); (!internal_isalnum_int_119.Invoke(((sbyte*)src)[num])) ? (((sbyte*)src)[num] == 95) : true; num = checked(num + 1L))
						{
						}
						if (((sbyte*)src)[num] == 41)
						{
							num = checked(num + 1L);
							cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, (byte*)src + (num5 + 1L), num - num5 - 2L);
							num4 = fputil_FPBits_float_StorageType_internal_nan_mantissa_from_ncharseq_float_cpp_string_view.Invoke(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
						}
						else
						{
							num = num5;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num5);
					}
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
					int field_ = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan_Sign_unsigned_int.Invoke(v: num4, sign: anon_izyfb9.val);
					fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
					llvm_lifetime_end_p0.Invoke(4L, &num4);
				}
			}
			else if (internal_tolower_int_118.Invoke(((sbyte*)src)[num]) == 105 && internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 1L)]) == ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[1] && internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 2L)]) == ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[2])
			{
				b = 1;
				llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_1_sign_const.Invoke(&fputil_FPBits_5nkvcs2);
				int field_2 = fputil_internal_FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf_Sign.Invoke(anon_izyfb10.val);
				fputil_FPBits_5nkvcs4.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs2, &fputil_FPBits_5nkvcs4, 4L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs4);
				num = ((internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 3L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[3] || internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 4L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[4] || internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 5L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[5] || internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 6L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[6] || internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 7L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[7]) ? checked(num + 3L) : checked(num + 8L));
			}
			if ((b & 1) != 1)
			{
				StrToNumResult_float_StrToNumResult_float_long_int.Invoke(&strToNumResult_jptppf, 0f, 0L, error);
			}
			else
			{
				void_internal_set_implicit_bit_float_fputil_FPBits_float.Invoke(&fputil_FPBits_5nkvcs2);
				StrToNumResult_float_StrToNumResult_float_long_int.Invoke(&strToNumResult_jptppf, fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2), num, error);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &error);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
			return *(Struct_fiz2nb*)(&strToNumResult_jptppf);
		}
	}
}
