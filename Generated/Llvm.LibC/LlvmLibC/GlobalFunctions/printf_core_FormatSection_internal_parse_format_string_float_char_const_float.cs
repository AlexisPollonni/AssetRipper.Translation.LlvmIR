using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal19parse_format_stringIfEENS_11printf_core13FormatSectionEPKcT_")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection __llvm_libc_20_1_2_::internal::parse_format_string<float>(char const*, float)")]
internal static partial class printf_core_FormatSection_internal_parse_format_string_float_char_const_float
{
	public unsafe static void Invoke([MangledName("agg.result")] printf_core_FormatSection* agg_result, void* format, float fp)
	{
		float num = 0f;
		long num2 = 0L;
		double num3 = 0.0;
		sbyte b = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		num = fp;
		llvm_memset_p0_i64.Invoke(agg_result, -86, 80L, isVolatile: false);
		printf_core_FormatSection_FormatSection.Invoke(agg_result);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = double.NaN;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 1;
		if ((b & 1) == 1)
		{
			num3 = num;
		}
		unchecked
		{
			if (((sbyte*)format)[num2] == 37)
			{
				agg_result->has_conv = 1;
				num2++;
				agg_result->precision = -1;
				if (((sbyte*)format)[num2] == 46)
				{
					num2++;
					agg_result->precision = 0;
					if (internal_isdigit_int_171.Invoke(((sbyte*)format)[num2]))
					{
						llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
						*(int*)(&strToNumResult_imtnam) = -1431655766;
						((int*)(&strToNumResult_imtnam))[1] = -1431655766;
						((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = StrToNumResult_int_internal_strtointeger_int_char_const_int_unsigned_long.Invoke((byte*)format + num2, 10, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_imtnam* num4 = &strToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num4 = struct_fiz2nb2.field_0;
						byte* num5 = (byte*)(&strToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num5 = struct_fiz2nb3.field_1;
						int value = strToNumResult_imtnam.value;
						long parsed_len;
						checked
						{
							agg_result->precision += value;
							parsed_len = strToNumResult_imtnam.parsed_len;
						}
						num2 += parsed_len;
						llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
					}
				}
				agg_result->conv_name = ((sbyte*)format)[num2];
				switch (((sbyte*)format)[num2])
				{
				case 65:
				case 97:
					if ((b & 1) == 1)
					{
						agg_result->conv_val_raw = (Int128)(UInt128)(ulong)cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(&num3);
					}
					else
					{
						agg_result->conv_val_raw = (Int128)(UInt128)(uint)cpp_enable_if_sizeof_unsigned_int_sizeof_float_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_float_value_unsigned_int_type_cpp_bit_cast_unsigned_int_float_float_const.Invoke(&num);
					}
					break;
				case 69:
				case 70:
				case 71:
				case 101:
				case 102:
				case 103:
					agg_result->conv_val_raw = (Int128)(UInt128)(uint)cpp_enable_if_sizeof_unsigned_int_sizeof_float_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_float_value_unsigned_int_type_cpp_bit_cast_unsigned_int_float_float_const.Invoke(&num);
					break;
				default:
					agg_result->has_conv = 0;
					for (; ((sbyte*)format)[num2] != 0; num2++)
					{
					}
					break;
				}
				if (((sbyte*)format)[num2] != 0)
				{
					num2++;
				}
			}
			else
			{
				agg_result->has_conv = 0;
				for (; ((sbyte*)format)[num2] != 0; num2++)
				{
				}
			}
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
			cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, format, num2);
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->raw_string, &cpp_string_view2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
		}
	}
}
