using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_parse_format_string_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal19parse_format_stringIdEENS_11printf_core13FormatSectionEPKcT_")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::FormatSection __llvm_libc_20_1_2_::internal::parse_format_string<double>(char const*, double)")]
	[return: NativeType("__llvm_libc_20_1_2_::printf_core::FormatSection")]
	public unsafe static void Invoke([MangledName("agg.result")] Printf_core_FormatSection* Agg_result, [MangledName("format")][NativeType("char const*")] void* Format, [MangledName("fp")][NativeType("double")] double Fp)
	{
		double num = 0.0;
		long num2 = 0L;
		double num3 = 0.0;
		sbyte b = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		num = Fp;
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 80L, isVolatile: false);
		FormatSection_Constructor_fn7xv9.Invoke(Agg_result);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = double.NaN;
		Llvm_lifetime_start_p0.Invoke(1L, &b);
		b = 0;
		if ((b & 1) == 1)
		{
			num3 = num;
		}
		unchecked
		{
			if (((sbyte*)Format)[num2] == 37)
			{
				Agg_result->Has_conv = 1;
				num2++;
				Agg_result->Precision = -1;
				if (((sbyte*)Format)[num2] == 46)
				{
					num2++;
					Agg_result->Precision = 0;
					if (Internal_isdigit_rkg48r.Invoke(((sbyte*)Format)[num2]))
					{
						Llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
						*(int*)(&strToNumResult_imtnam) = -1431655766;
						((int*)(&strToNumResult_imtnam))[1] = -1431655766;
						((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)Format + num2, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_imtnam* num4 = &strToNumResult_imtnam;
						Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
						*(long*)num4 = struct_fiz2nb2.field_0;
						byte* num5 = (byte*)(&strToNumResult_imtnam) + 8u;
						Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
						*(long*)num5 = struct_fiz2nb3.field_1;
						int value = strToNumResult_imtnam.Value;
						long parsed_len;
						checked
						{
							Agg_result->Precision += value;
							parsed_len = strToNumResult_imtnam.Parsed_len;
						}
						num2 += parsed_len;
						Llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
					}
				}
				Agg_result->Conv_name = ((sbyte*)Format)[num2];
				switch (((sbyte*)Format)[num2])
				{
				case 65:
				case 97:
					if ((b & 1) == 1)
					{
						Agg_result->Conv_val_raw = (Int128)(UInt128)(ulong)Cpp_bit_cast_unsigned_long_double.Invoke(&num3);
					}
					else
					{
						Agg_result->Conv_val_raw = (Int128)(UInt128)(ulong)Cpp_bit_cast_unsigned_long_double.Invoke(&num);
					}
					break;
				case 69:
				case 70:
				case 71:
				case 101:
				case 102:
				case 103:
					Agg_result->Conv_val_raw = (Int128)(UInt128)(ulong)Cpp_bit_cast_unsigned_long_double.Invoke(&num);
					break;
				default:
					Agg_result->Has_conv = 0;
					for (; ((sbyte*)Format)[num2] != 0; num2++)
					{
					}
					break;
				}
				if (((sbyte*)Format)[num2] != 0)
				{
					num2++;
				}
			}
			else
			{
				Agg_result->Has_conv = 0;
				for (; ((sbyte*)Format)[num2] != 0; num2++)
				{
				}
			}
			Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view);
			String_view_Constructor.Invoke(&cpp_string_view, Format, num2);
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Raw_string, &cpp_string_view, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view);
			Llvm_lifetime_end_p0.Invoke(1L, &b);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
		}
	}
}
