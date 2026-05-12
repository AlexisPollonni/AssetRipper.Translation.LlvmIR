using System;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIeEENS_14StrToNumResultIT_EEPKc")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double> __llvm_libc_20_1_2_::internal::strtofloatingpoint<long double>(char const*)")]
internal static partial class StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const
{
	public unsafe static void Invoke([MangledName("agg.result")] StrToNumResult_6sg7zz* agg_result, void* src)
	{
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi3 = default(fputil_FPBits_ubgsi2);
		sbyte b = 0;
		sbyte b2 = 0;
		int error = 0;
		long num = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		int num2 = 0;
		int num3 = 0;
		StrToNumResult_ggsbhp strToNumResult_ggsbhp = default(StrToNumResult_ggsbhp);
		internal_ExpandedFloat_9jummq internal_ExpandedFloat_9jummq2 = default(internal_ExpandedFloat_9jummq);
		StrToNumResult_ggsbhp strToNumResult_ggsbhp2 = default(StrToNumResult_ggsbhp);
		StrToNumResult_ggsbhp strToNumResult_ggsbhp3 = default(StrToNumResult_ggsbhp);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		long num4 = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		Int128 int4 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi4 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb9 = default(anon_izyfb7);
		Int128 int5 = default(Int128);
		fputil_FPBits_ubgsi2 fputil_FPBits_ubgsi5 = default(fputil_FPBits_ubgsi2);
		anon_izyfb7 anon_izyfb10 = default(anon_izyfb7);
		llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		unchecked
		{
			*(Int128*)(&fputil_FPBits_ubgsi3) = -6148914691236517206L;
			llvm_memset_p0_i64.Invoke(&fputil_FPBits_ubgsi3, 0, 16L, isVolatile: false);
			fputil_FPBits_long_double_FPBits.Invoke(&fputil_FPBits_ubgsi3);
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
				fputil_internal_FPStorage_fputil_FPType_4_set_sign_Sign.Invoke(&fputil_FPBits_ubgsi3, anon_izyfb8.val);
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
				llvm_lifetime_start_p0.Invoke(48L, &strToNumResult_ggsbhp);
				llvm_memset_p0_i64.Invoke(&strToNumResult_ggsbhp, -86, 48L, isVolatile: false);
				llvm_memset_p0_i64.Invoke(&internal_ExpandedFloat_9jummq2, 0, 32L, isVolatile: false);
				_ = ref internal_ExpandedFloat_9jummq2.mantissa;
				_ = ref internal_ExpandedFloat_9jummq2.exponent;
				StrToNumResult_internal_ExpandedFloat_long_double_StrToNumResult_internal_ExpandedFloat_long_double.Invoke(&strToNumResult_ggsbhp, &internal_ExpandedFloat_9jummq2);
				if (num2 == 16)
				{
					llvm_lifetime_start_p0.Invoke(48L, &strToNumResult_ggsbhp2);
					StrToNumResult_internal_ExpandedFloat_long_double_internal_hexadecimal_string_to_float_long_double_char_const_char_internal_RoundDirection.Invoke(&strToNumResult_ggsbhp2, (byte*)src + num, 46, (RoundDirection_b3pcwy)num3);
					llvm_memcpy_p0_p0_i64.Invoke(&strToNumResult_ggsbhp, &strToNumResult_ggsbhp2, 48L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(48L, &strToNumResult_ggsbhp2);
				}
				else
				{
					llvm_lifetime_start_p0.Invoke(48L, &strToNumResult_ggsbhp3);
					StrToNumResult_internal_ExpandedFloat_long_double_internal_decimal_string_to_float_long_double_char_const_char_internal_RoundDirection.Invoke(&strToNumResult_ggsbhp3, (byte*)src + num, 46, (RoundDirection_b3pcwy)num3);
					llvm_memcpy_p0_p0_i64.Invoke(&strToNumResult_ggsbhp, &strToNumResult_ggsbhp3, 48L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(48L, &strToNumResult_ggsbhp3);
				}
				b = ((strToNumResult_ggsbhp.parsed_len != 0L) ? ((sbyte)1) : ((sbyte)0));
				@int = strToNumResult_ggsbhp.value.mantissa;
				fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&@int), ((long*)(&@int))[1]);
				int2 = strToNumResult_ggsbhp.value.exponent;
				fputil_internal_FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent_unsigned_int128.Invoke(&fputil_FPBits_ubgsi3, *(long*)(&int2), ((long*)(&int2))[1]);
				long parsed_len = strToNumResult_ggsbhp.parsed_len;
				num = checked(num + parsed_len);
				error = strToNumResult_ggsbhp.error;
				llvm_lifetime_end_p0.Invoke(48L, &strToNumResult_ggsbhp);
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			else if (internal_tolower_int_118.Invoke(((sbyte*)src)[num]) == 110)
			{
				if (internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 1L)]) == ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_nan_string.Value)[1] && internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 2L)]) == ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_nan_string.Value)[2])
				{
					b = 1;
					num = checked(num + 3L);
					llvm_lifetime_start_p0.Invoke(16L, &int3);
					int3 = 0L;
					if (((sbyte*)src)[num] == 40)
					{
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = num;
						for (num = checked(num + 1L); (!internal_isalnum_int_119.Invoke(((sbyte*)src)[num])) ? (((sbyte*)src)[num] == 95) : true; num = checked(num + 1L))
						{
						}
						if (((sbyte*)src)[num] == 41)
						{
							num = checked(num + 1L);
							cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, (byte*)src + (num4 + 1L), num - num4 - 2L);
							Struct_fiz2nb struct_fiz2nb = fputil_FPBits_long_double_StorageType_internal_nan_mantissa_from_ncharseq_long_double_cpp_string_view.Invoke(*(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]);
							Int128* num5 = &int4;
							Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
							*(long*)num5 = struct_fiz2nb2.field_0;
							byte* num6 = (byte*)(&int4) + 8u;
							Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
							*(long*)num6 = struct_fiz2nb3.field_1;
							int3 = int4;
						}
						else
						{
							num = num4;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num4);
					}
					llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					anon_izyfb9.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
					Int128 int6 = int3;
					sbyte val = anon_izyfb9.val;
					int5 = int6;
					Struct_fiz2nb struct_fiz2nb4 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan_Sign_unsigned_int128.Invoke(val, *(long*)(&int5), ((long*)(&int5))[1]);
					Int128* ptr = &fputil_FPBits_ubgsi4.val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
					llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi4, 16L, isVolatile: false);
					llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi4);
					llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
			}
			else if (internal_tolower_int_118.Invoke(((sbyte*)src)[num]) == 105 && internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 1L)]) == ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[1] && internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 2L)]) == ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[2])
			{
				b = 1;
				llvm_lifetime_start_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				anon_izyfb10.val = fputil_internal_FPStorage_fputil_FPType_4_sign_const.Invoke(&fputil_FPBits_ubgsi3);
				Struct_fiz2nb struct_fiz2nb7 = fputil_internal_FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf_Sign.Invoke(anon_izyfb10.val);
				Int128* ptr2 = &fputil_FPBits_ubgsi5.val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb8.field_0;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb9.field_1;
				llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_ubgsi3, &fputil_FPBits_ubgsi5, 16L, isVolatile: false);
				llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi5);
				num = ((internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 3L)]) != ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[3] || internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 4L)]) != ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[4] || internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 5L)]) != ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[5] || internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 6L)]) != ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[6] || internal_tolower_int_118.Invoke(((sbyte*)src)[checked(num + 7L)]) != ((sbyte*)StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[7]) ? checked(num + 3L) : checked(num + 8L));
			}
			if ((b & 1) != 1)
			{
				StrToNumResult_long_double_StrToNumResult_long_double_long_int.Invoke(agg_result, 0.0, 0L, error);
			}
			else
			{
				void_internal_set_implicit_bit_long_double_fputil_FPBits_long_double.Invoke(&fputil_FPBits_ubgsi3);
				StrToNumResult_long_double_StrToNumResult_long_double_long_int.Invoke(agg_result, fputil_FPBits_long_double_get_val_const.Invoke(&fputil_FPBits_ubgsi3), num, error);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(4L, &error);
			llvm_lifetime_end_p0.Invoke(1L, &b2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(16L, &fputil_FPBits_ubgsi3);
		}
	}
}
