using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_strtofloatingpoint_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18strtofloatingpointIfEENS_14StrToNumResultIT_EEPKc")]
	[DemangledName("__llvm_libc_20_1_2_::StrToNumResult<float> __llvm_libc_20_1_2_::internal::strtofloatingpoint<float>(char const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::StrToNumResult<float>")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("src")][NativeType("char const*")] void* Src)
	{
		StrToNumResult_cqc3yy strToNumResult_cqc3yy = default(StrToNumResult_cqc3yy);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs = default(Fputil_FPBits_5nkvcs);
		sbyte b = 0;
		sbyte b2 = 0;
		int error = 0;
		long num = 0L;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		int num2 = 0;
		int round = 0;
		StrToNumResult_kkgahp strToNumResult_kkgahp = default(StrToNumResult_kkgahp);
		Internal_ExpandedFloat_i7t5up internal_ExpandedFloat_i7t5up = default(Internal_ExpandedFloat_i7t5up);
		StrToNumResult_kkgahp strToNumResult_kkgahp2 = default(StrToNumResult_kkgahp);
		StrToNumResult_kkgahp strToNumResult_kkgahp3 = default(StrToNumResult_kkgahp);
		int num3 = 0;
		long num4 = 0L;
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb2 = default(Anon_izyfb7);
		Fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs3 = default(Fputil_FPBits_5nkvcs);
		Anon_izyfb7 anon_izyfb3 = default(Anon_izyfb7);
		Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
		unchecked
		{
			*(int*)(&fputil_FPBits_5nkvcs) = -1431655766;
			Llvm_memset_p0_i64.Invoke(&fputil_FPBits_5nkvcs, 0, 4L, isVolatile: false);
			FPBits_float_Constructor.Invoke(&fputil_FPBits_5nkvcs);
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
				Llvm_memcpy_p0_p0_i64.Invoke(&anon_izyfb, Sign_NEG.Pointer, 1L, isVolatile: false);
				FPStorage_fputil_FPType_1_set_sign.Invoke(&fputil_FPBits_5nkvcs, anon_izyfb.Val);
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
				Llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_kkgahp);
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
				internal_ExpandedFloat_i7t5up.Mantissa = 0;
				internal_ExpandedFloat_i7t5up.Exponent = 0;
				StrToNumResult_internal_ExpandedFloat_float_Constructor.Invoke(&strToNumResult_kkgahp, *(long*)(&internal_ExpandedFloat_i7t5up));
				if (num2 == 16)
				{
					Llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_kkgahp2);
					Internal_hexadecimal_string_to_float_float.Invoke(&strToNumResult_kkgahp2, (byte*)Src + num, 46, (RoundDirection_b3pcwy)round);
					Llvm_memcpy_p0_p0_i64.Invoke(&strToNumResult_kkgahp, &strToNumResult_kkgahp2, 24L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_kkgahp2);
				}
				else
				{
					Llvm_lifetime_start_p0.Invoke(24L, &strToNumResult_kkgahp3);
					Internal_decimal_string_to_float_float.Invoke(&strToNumResult_kkgahp3, (byte*)Src + num, 46, (RoundDirection_b3pcwy)round);
					Llvm_memcpy_p0_p0_i64.Invoke(&strToNumResult_kkgahp, &strToNumResult_kkgahp3, 24L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_kkgahp3);
				}
				b = ((strToNumResult_kkgahp.Parsed_len != 0L) ? ((sbyte)1) : ((sbyte)0));
				FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_mantissa.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs), strToNumResult_kkgahp.Value.Mantissa);
				FPRepImpl_fputil_FPType_1_fputil_FPBits_float_set_biased_exponent.Invoke((Fputil_internal_FPRepImpl_vhj4tm*)(&fputil_FPBits_5nkvcs), strToNumResult_kkgahp.Value.Exponent);
				long parsed_len = strToNumResult_kkgahp.Parsed_len;
				num = checked(num + parsed_len);
				error = strToNumResult_kkgahp.Error;
				Llvm_lifetime_end_p0.Invoke(24L, &strToNumResult_kkgahp);
				Llvm_lifetime_end_p0.Invoke(4L, &round);
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
			}
			else if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num]) == 110)
			{
				if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 1L)]) == ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_nan_string.Value)[1] && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 2L)]) == ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_nan_string.Value)[2])
				{
					b = 1;
					num = checked(num + 3L);
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					num3 = 0;
					if (((sbyte*)Src)[num] == 40)
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = num;
						for (num = checked(num + 1L); Internal_isalnum_eh69hd.Invoke(((sbyte*)Src)[num]) || ((sbyte*)Src)[num] == 95; num = checked(num + 1L))
						{
						}
						if (((sbyte*)Src)[num] == 41)
						{
							num = checked(num + 1L);
							String_view_Constructor.Invoke(&cpp_string_view, (byte*)Src + (num4 + 1L), num - num4 - 2L);
							num3 = Internal_nan_mantissa_from_ncharseq_float.Invoke(*(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]);
						}
						else
						{
							num = num4;
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num4);
					}
					Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					anon_izyfb2.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
					int field_ = FPRepSem_fputil_FPType_1_fputil_FPBits_float_quiet_nan.Invoke(V: num3, Sign: anon_izyfb2.Val);
					fputil_FPBits_5nkvcs2.FPRepImpl.FPRepSem.field_0.field_0 = field_;
					Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs2, 4L, isVolatile: false);
					Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
				}
			}
			else if (Internal_tolower_b2645y.Invoke(((sbyte*)Src)[num]) == 105 && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 1L)]) == ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[1] && Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 2L)]) == ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[2])
			{
				b = 1;
				Llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				anon_izyfb3.Val = FPStorage_fputil_FPType_1_sign.Invoke(&fputil_FPBits_5nkvcs);
				int field_2 = FPRepSem_fputil_FPType_1_fputil_FPBits_float_inf.Invoke(anon_izyfb3.Val);
				fputil_FPBits_5nkvcs3.FPRepImpl.FPRepSem.field_0.field_0 = field_2;
				Llvm_memcpy_p0_p0_i64.Invoke(&fputil_FPBits_5nkvcs, &fputil_FPBits_5nkvcs3, 4L, isVolatile: false);
				Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs3);
				num = ((Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 3L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[3] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 4L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[4] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 5L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[5] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 6L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[6] || Internal_tolower_b2645y.Invoke(((sbyte*)Src)[checked(num + 7L)]) != ((sbyte*)StrToNumResult_float_internal_strtofloatingpoint_float_char_const_inf_string.Value)[7]) ? checked(num + 3L) : checked(num + 8L));
			}
			if ((b & 1) != 1)
			{
				StrToNumResult_float_Constructor.Invoke(&strToNumResult_cqc3yy, 0f, 0L, error);
			}
			else
			{
				Internal_set_implicit_bit_float.Invoke(&fputil_FPBits_5nkvcs);
				StrToNumResult_float_Constructor.Invoke(&strToNumResult_cqc3yy, FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs), num, error);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(4L, &error);
			Llvm_lifetime_end_p0.Invoke(1L, &b2);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs);
			return *(Struct_fiz2nb*)(&strToNumResult_cqc3yy);
		}
	}
}
