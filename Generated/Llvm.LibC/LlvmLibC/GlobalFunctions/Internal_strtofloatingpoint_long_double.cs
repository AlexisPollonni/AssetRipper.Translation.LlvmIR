using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strtofloatingpoint_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIeEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<long double> __llvm_libc_20_1_2_::internal::strtofloatingpoint<long double>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<long double>")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_StrToNumResult_uytq62* Agg_result, [MangledName("src")][NativeType("char const*")] void* Src)
	{
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		sbyte b = 0;
		sbyte b2 = 0;
		int error = 0;
		long num = 0L;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num2 = 0;
		int round = 0;
		Llvm_libc_20_1_2_StrToNumResult_ggsbhp llvm_libc_20_1_2_StrToNumResult_ggsbhp = default(Llvm_libc_20_1_2_StrToNumResult_ggsbhp);
		Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq llvm_libc_20_1_2_internal_ExpandedFloat_9jummq = default(Llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
		Llvm_libc_20_1_2_StrToNumResult_ggsbhp llvm_libc_20_1_2_StrToNumResult_ggsbhp2 = default(Llvm_libc_20_1_2_StrToNumResult_ggsbhp);
		Llvm_libc_20_1_2_StrToNumResult_ggsbhp llvm_libc_20_1_2_StrToNumResult_ggsbhp3 = default(Llvm_libc_20_1_2_StrToNumResult_ggsbhp);
		Int128 @int = default(Int128);
		Int128 int2 = default(Int128);
		Int128 int3 = default(Int128);
		long num3 = 0L;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Int128 int4 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi2 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Int128 int5 = default(Int128);
		Llvm_libc_20_1_2_fputil_FPBits_ubgsi2 llvm_libc_20_1_2_fputil_FPBits_ubgsi3 = default(Llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		unchecked
		{
			*(Int128*)(&llvm_libc_20_1_2_fputil_FPBits_ubgsi) = -6148914691236517206L;
			Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, 0, 16L, isVolatile: false);
			FPBits_long_double_Constructor.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
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
				FPStorage_fputil_FPType_4_set_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, anon_izyfb.Val);
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
				Llvm_lifetime_start_p0.Invoke(48L, &llvm_libc_20_1_2_StrToNumResult_ggsbhp);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_StrToNumResult_ggsbhp, -86, 48L, isVolatile: false);
				Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_internal_ExpandedFloat_9jummq, 0, 32L, isVolatile: false);
				_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq.Mantissa;
				_ = ref llvm_libc_20_1_2_internal_ExpandedFloat_9jummq.Exponent;
				StrToNumResult_internal_ExpandedFloat_long_double_Constructor.Invoke(&llvm_libc_20_1_2_StrToNumResult_ggsbhp, &llvm_libc_20_1_2_internal_ExpandedFloat_9jummq);
				if (num2 == 16)
				{
					Llvm_lifetime_start_p0.Invoke(48L, &llvm_libc_20_1_2_StrToNumResult_ggsbhp2);
					Internal_hexadecimal_string_to_float_long_double.Invoke(&llvm_libc_20_1_2_StrToNumResult_ggsbhp2, (byte*)Src + num, 46, (RoundDirection_b3pcwy)round);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_StrToNumResult_ggsbhp, &llvm_libc_20_1_2_StrToNumResult_ggsbhp2, 48L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(48L, &llvm_libc_20_1_2_StrToNumResult_ggsbhp2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(48L, &llvm_libc_20_1_2_StrToNumResult_ggsbhp3);
					Internal_decimal_string_to_float_long_double.Invoke(&llvm_libc_20_1_2_StrToNumResult_ggsbhp3, (byte*)Src + num, 46, (RoundDirection_b3pcwy)round);
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_StrToNumResult_ggsbhp, &llvm_libc_20_1_2_StrToNumResult_ggsbhp3, 48L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(48L, &llvm_libc_20_1_2_StrToNumResult_ggsbhp3);
				}
				b = ((llvm_libc_20_1_2_StrToNumResult_ggsbhp.Parsed_len != 0L) ? ((sbyte)1) : ((sbyte)0));
				@int = llvm_libc_20_1_2_StrToNumResult_ggsbhp.Value.Mantissa;
				FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_mantissa.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&@int), ((long*)(&@int))[1]);
				int2 = llvm_libc_20_1_2_StrToNumResult_ggsbhp.Value.Exponent;
				FPRepImpl_fputil_FPType_4_fputil_FPBits_long_double_set_biased_exponent.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, *(long*)(&int2), ((long*)(&int2))[1]);
				long parsed_len = llvm_libc_20_1_2_StrToNumResult_ggsbhp.Parsed_len;
				num = checked(num + parsed_len);
				error = llvm_libc_20_1_2_StrToNumResult_ggsbhp.Error;
				Llvm_lifetime_end_p0.Invoke(48L, &llvm_libc_20_1_2_StrToNumResult_ggsbhp);
				Llvm_lifetime_end_p0.Invoke(4L, &round);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			else if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num]) == 110)
			{
				if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 1L)]) == ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_nan_string.Value)[1] && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 2L)]) == ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_nan_string.Value)[2])
				{
					b = 1;
					num = checked(num + 3L);
					Llvm_lifetime_start_p0.Invoke(16L, &int3);
					int3 = 0L;
					if (((sbyte*)Src)[num] == 40)
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num3);
						num3 = num;
						for (num = checked(num + 1L); (!Internal_isalnum_eh69hd.Invoke(((sbyte*)Src)[num])) ? (((sbyte*)Src)[num] == 95) : true; num = checked(num + 1L))
						{
						}
						if (((sbyte*)Src)[num] == 41)
						{
							num = checked(num + 1L);
							String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, (byte*)Src + (num3 + 1L), num - num3 - 2L);
							Struct_fiz2nb struct_fiz2nb = Internal_nan_mantissa_from_ncharseq_long_double.Invoke(*(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]);
							Int128* num4 = &int4;
							Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
							*(long*)num4 = struct_fiz2nb2.field_0;
							byte* num5 = (byte*)(&int4) + 8u;
							Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
							*(long*)num5 = struct_fiz2nb3.field_1;
							int3 = int4;
						}
						else
						{
							num = num3;
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num3);
					}
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					anon_izyfb2.Val = FPStorage_fputil_FPType_4_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
					Int128 int6 = int3;
					sbyte val = anon_izyfb2.Val;
					int5 = int6;
					Struct_fiz2nb struct_fiz2nb4 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_quiet_nan.Invoke(val, *(long*)(&int5), ((long*)(&int5))[1]);
					Int128* ptr = &llvm_libc_20_1_2_fputil_FPBits_ubgsi2.Val.Data.FPStorage.field_0;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr)->field_0 = struct_fiz2nb5.field_0;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					((Struct_fiz2nb*)ptr)->field_1 = struct_fiz2nb6.field_1;
					Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2, 16L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi2);
					Llvm_lifetime_end_p0.Invoke(16L, &int3);
				}
			}
			else if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num]) == 105 && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 1L)]) == ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[1] && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 2L)]) == ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[2])
			{
				b = 1;
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				anon_izyfb3.Val = FPStorage_fputil_FPType_4_sign.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				Struct_fiz2nb struct_fiz2nb7 = FPRepSem_fputil_FPType_4_fputil_FPBits_long_double_inf.Invoke(anon_izyfb3.Val);
				Int128* ptr2 = &llvm_libc_20_1_2_fputil_FPBits_ubgsi3.Val.Data.FPStorage.field_0;
				Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr2)->field_0 = struct_fiz2nb8.field_0;
				Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
				((Struct_fiz2nb*)ptr2)->field_1 = struct_fiz2nb9.field_1;
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3, 16L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi3);
				num = ((Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 3L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[3] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 4L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[4] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 5L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[5] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 6L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[6] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 7L)]) != ((sbyte*)Llvm_libc_20_1_2_StrToNumResult_long_double_internal_strtofloatingpoint_long_double_char_const_inf_string.Value)[7]) ? checked(num + 3L) : checked(num + 8L));
			}
			if ((b & 1) != 1)
			{
				StrToNumResult_long_double_Constructor.Invoke(Agg_result, 0.0, 0L, error);
			}
			else
			{
				Internal_set_implicit_bit_long_double.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi);
				StrToNumResult_long_double_Constructor.Invoke(Agg_result, FPBits_long_double_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_ubgsi), num, error);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &error);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_fputil_FPBits_ubgsi);
		}
	}
}
