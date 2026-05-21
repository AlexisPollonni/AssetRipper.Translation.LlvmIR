using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_parse_format_string_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal19parse_format_stringIeEENS_11printf_core13FormatSectionEPKcT_")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection __llvm_libc_20_1_2_::internal::parse_format_string<long double>(char const*, long double)")]
	[return: NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection")]
	public unsafe static void Invoke([MangledName("agg.result")] printf_core_FormatSection* agg_result, [NativeType("char const*")] void* format, [NativeType("long double")] double fp)
	{
		double num = 0.0;
		long num2 = 0L;
		double num3 = 0.0;
		sbyte b = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		Int128 conv_val_raw = default(Int128);
		Int128 conv_val_raw2 = default(Int128);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		num = fp;
		llvm_memset_p0_i64.Invoke(agg_result, -86, 80L, isVolatile: false);
		FormatSection_Constructor_fn7xv9.Invoke(agg_result);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = double.NaN;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
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
					if (internal_isdigit_ydbc7e.Invoke(((sbyte*)format)[num2]))
					{
						llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
						*(int*)(&strToNumResult_imtnam) = -1431655766;
						((int*)(&strToNumResult_imtnam))[1] = -1431655766;
						((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = internal_strtointeger_int.Invoke((byte*)format + num2, 10, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
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
				{
					if ((b & 1) == 1)
					{
						agg_result->conv_val_raw = (Int128)(UInt128)(ulong)cpp_bit_cast_unsigned_long_double.Invoke(&num3);
						break;
					}
					Struct_fiz2nb struct_fiz2nb4 = cpp_bit_cast_unsigned_int128_long_double.Invoke(&num);
					Int128* num6 = &conv_val_raw;
					Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
					*(long*)num6 = struct_fiz2nb5.field_0;
					byte* num7 = (byte*)(&conv_val_raw) + 8u;
					Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
					*(long*)num7 = struct_fiz2nb6.field_1;
					agg_result->conv_val_raw = conv_val_raw;
					break;
				}
				case 69:
				case 70:
				case 71:
				case 101:
				case 102:
				case 103:
				{
					Struct_fiz2nb struct_fiz2nb7 = cpp_bit_cast_unsigned_int128_long_double.Invoke(&num);
					Int128* num8 = &conv_val_raw2;
					Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
					*(long*)num8 = struct_fiz2nb8.field_0;
					byte* num9 = (byte*)(&conv_val_raw2) + 8u;
					Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
					*(long*)num9 = struct_fiz2nb9.field_1;
					agg_result->conv_val_raw = conv_val_raw2;
					break;
				}
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
			string_view_Constructor.Invoke(&cpp_string_view2, format, num2);
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->raw_string, &cpp_string_view2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
		}
	}
}
