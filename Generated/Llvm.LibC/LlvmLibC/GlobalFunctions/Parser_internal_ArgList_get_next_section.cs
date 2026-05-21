using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_get_next_section
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE16get_next_sectionEv")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_section()")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_scanf_core_FormatSection* Agg_result, [MangledName("this")] Llvm_libc_20_1_2_scanf_core_Parser* This)
	{
		long num = 0L;
		long index = 0L;
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		int num2 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		Llvm_libc_20_1_2_cpp_array_jgy3xh llvm_libc_20_1_2_cpp_array_jgy3xh = default(Llvm_libc_20_1_2_cpp_array_jgy3xh);
		sbyte b4 = 0;
		long num3 = 0L;
		sbyte b5 = 0;
		sbyte b6 = 0;
		sbyte b7 = 0;
		sbyte b8 = 0;
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 88L, isVolatile: false);
		FormatSection_Constructor_ea9nd2.Invoke(Agg_result);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = This->Cur_pos;
		unchecked
		{
			if (((sbyte*)This->Str)[This->Cur_pos] == 37)
			{
				Agg_result->Has_conv = 1;
				This->Cur_pos++;
				Llvm_lifetime_start_p0.Invoke(8L, &index);
				index = 0L;
				index = Parser_internal_ArgList_parse_index_uewqxq.Invoke(This, &This->Cur_pos);
				if (((sbyte*)This->Str)[This->Cur_pos] == 42)
				{
					This->Cur_pos++;
					Agg_result->Flags = FormatFlags_96pze4.NO_WRITE;
				}
				Agg_result->Max_width = -1;
				if (Internal_isdigit_gvvitd.Invoke(((sbyte*)This->Str)[This->Cur_pos]))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
					*(int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) = -1431655766;
					((int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -1431655766;
					((long*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)This->Str + This->Cur_pos, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					Llvm_libc_20_1_2_StrToNumResult_imtnam* num4 = &llvm_libc_20_1_2_StrToNumResult_imtnam;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num4 = struct_fiz2nb2.field_0;
					byte* num5 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num5 = struct_fiz2nb3.field_1;
					Agg_result->Max_width = llvm_libc_20_1_2_StrToNumResult_imtnam.Value;
					This->Cur_pos += llvm_libc_20_1_2_StrToNumResult_imtnam.Parsed_len;
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
				}
				Llvm_lifetime_start_p0.Invoke(4L, &num2);
				num2 = (int)(Agg_result->Length_modifier = Parser_internal_ArgList_parse_length_modifier.Invoke(This, &This->Cur_pos));
				Agg_result->Conv_name = ((sbyte*)This->Str)[This->Cur_pos];
				if (((byte)Agg_result->Flags & 1) == 0)
				{
					Agg_result->Output_ptr = Parser_internal_ArgList_get_arg_value_void.Invoke(This, index);
				}
				if (((sbyte*)This->Str)[This->Cur_pos] != 0)
				{
					This->Cur_pos++;
				}
				else
				{
					Agg_result->Has_conv = 0;
				}
				if (Agg_result->Conv_name == 91)
				{
					Llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 93;
					Llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = 94;
					Llvm_lifetime_start_p0.Invoke(1L, &b3);
					b3 = 45;
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_array_jgy3xh);
					sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_array_jgy3xh);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					((long*)ptr)[2] = -6148914691236517206L;
					((long*)ptr)[3] = -6148914691236517206L;
					Bitset_256ul_Constructor.Invoke(&llvm_libc_20_1_2_cpp_array_jgy3xh);
					Llvm_lifetime_start_p0.Invoke(1L, &b4);
					b4 = 0;
					if (((sbyte*)This->Str)[This->Cur_pos] == 94)
					{
						b4 = 1;
						This->Cur_pos++;
					}
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = This->Cur_pos;
					if (((sbyte*)This->Str)[This->Cur_pos] == 93)
					{
						Bitset_256ul_set.Invoke(&llvm_libc_20_1_2_cpp_array_jgy3xh, 93L);
						This->Cur_pos++;
					}
					while (((sbyte*)This->Str)[This->Cur_pos] != 0 && ((sbyte*)This->Str)[This->Cur_pos] != 93)
					{
						if (((sbyte*)This->Str)[This->Cur_pos] == 45 && This->Cur_pos != num3 && ((sbyte*)This->Str)[This->Cur_pos + 1L] != 93 && ((sbyte*)This->Str)[This->Cur_pos + 1L] != 0)
						{
							Llvm_lifetime_start_p0.Invoke(1L, &b5);
							b5 = ((sbyte*)This->Str)[This->Cur_pos - 1L];
							Llvm_lifetime_start_p0.Invoke(1L, &b6);
							b6 = ((sbyte*)This->Str)[This->Cur_pos + 1L];
							Llvm_lifetime_start_p0.Invoke(1L, &b7);
							b7 = ((b5 >= b6) ? b6 : b5);
							Llvm_lifetime_start_p0.Invoke(1L, &b8);
							b8 = ((b5 >= b6) ? b5 : b6);
							Bitset_256ul_set_range.Invoke(&llvm_libc_20_1_2_cpp_array_jgy3xh, b7, b8);
							This->Cur_pos += 2L;
							Llvm_lifetime_end_p0.Invoke(1L, &b8);
							Llvm_lifetime_end_p0.Invoke(1L, &b7);
							Llvm_lifetime_end_p0.Invoke(1L, &b6);
							Llvm_lifetime_end_p0.Invoke(1L, &b5);
						}
						else
						{
							Bitset_256ul_set.Invoke(&llvm_libc_20_1_2_cpp_array_jgy3xh, ((sbyte*)This->Str)[This->Cur_pos]);
							This->Cur_pos++;
						}
					}
					if ((b4 & 1) == 1)
					{
						Bitset_256ul_flip.Invoke(&llvm_libc_20_1_2_cpp_array_jgy3xh);
					}
					if (((sbyte*)This->Str)[This->Cur_pos] == 93)
					{
						This->Cur_pos++;
						Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Scan_set, &llvm_libc_20_1_2_cpp_array_jgy3xh, 32L, isVolatile: false);
					}
					else
					{
						Agg_result->Has_conv = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
					Llvm_lifetime_end_p0.Invoke(1L, &b4);
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_array_jgy3xh);
					Llvm_lifetime_end_p0.Invoke(1L, &b3);
					Llvm_lifetime_end_p0.Invoke(1L, &b2);
					Llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				Llvm_lifetime_end_p0.Invoke(4L, &num2);
				Llvm_lifetime_end_p0.Invoke(8L, &index);
			}
			else
			{
				Agg_result->Has_conv = 0;
				while (((sbyte*)This->Str)[This->Cur_pos] != 37 && ((sbyte*)This->Str)[This->Cur_pos] != 0)
				{
					This->Cur_pos++;
				}
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, (byte*)This->Str + num, This->Cur_pos - num);
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Raw_string, &llvm_libc_20_1_2_cpp_string_view, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE16get_next_sectionEv")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_section()")]
	public unsafe static void Invoke([MangledName("agg.result")] Llvm_libc_20_1_2_printf_core_FormatSection* Agg_result, [MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This)
	{
		long num = 0L;
		long index = 0L;
		Llvm_libc_20_1_2_cpp_optional_g66fk4 llvm_libc_20_1_2_cpp_optional_g66fk = default(Llvm_libc_20_1_2_cpp_optional_g66fk4);
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		Llvm_libc_20_1_2_cpp_optional_g66fk4 llvm_libc_20_1_2_cpp_optional_g66fk2 = default(Llvm_libc_20_1_2_cpp_optional_g66fk4);
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam2 = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		Llvm_libc_20_1_2_printf_core_LengthSpec llvm_libc_20_1_2_printf_core_LengthSpec = default(Llvm_libc_20_1_2_printf_core_LengthSpec);
		Llvm_libc_20_1_2_cpp_optional_g66fk4 llvm_libc_20_1_2_cpp_optional_g66fk3 = default(Llvm_libc_20_1_2_cpp_optional_g66fk4);
		Llvm_libc_20_1_2_cpp_optional_g66fk4 llvm_libc_20_1_2_cpp_optional_g66fk4 = default(Llvm_libc_20_1_2_cpp_optional_g66fk4);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji2 = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji3 = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji4 = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji5 = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_g66fk4 llvm_libc_20_1_2_cpp_optional_g66fk5 = default(Llvm_libc_20_1_2_cpp_optional_g66fk4);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji6 = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji7 = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji8 = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_vhbvq7 llvm_libc_20_1_2_cpp_optional_vhbvq = default(Llvm_libc_20_1_2_cpp_optional_vhbvq7);
		Llvm_libc_20_1_2_cpp_optional_59q3zq llvm_libc_20_1_2_cpp_optional_59q3zq = default(Llvm_libc_20_1_2_cpp_optional_59q3zq);
		Int128 conv_val_raw = default(Int128);
		Llvm_libc_20_1_2_cpp_optional_g66fk4 llvm_libc_20_1_2_cpp_optional_g66fk6 = default(Llvm_libc_20_1_2_cpp_optional_g66fk4);
		Llvm_libc_20_1_2_cpp_optional_d6hvji llvm_libc_20_1_2_cpp_optional_d6hvji9 = default(Llvm_libc_20_1_2_cpp_optional_d6hvji);
		Llvm_libc_20_1_2_cpp_optional_g66fk4 llvm_libc_20_1_2_cpp_optional_g66fk7 = default(Llvm_libc_20_1_2_cpp_optional_g66fk4);
		Llvm_libc_20_1_2_cpp_optional_77yu8f llvm_libc_20_1_2_cpp_optional_77yu8f = default(Llvm_libc_20_1_2_cpp_optional_77yu8f);
		Llvm_libc_20_1_2_cpp_optional_77yu8f llvm_libc_20_1_2_cpp_optional_77yu8f2 = default(Llvm_libc_20_1_2_cpp_optional_77yu8f);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_memset_p0_i64.Invoke(Agg_result, -86, 80L, isVolatile: false);
		FormatSection_Constructor_fn7xv9.Invoke(Agg_result);
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = This->Cur_pos;
		unchecked
		{
			if (((sbyte*)This->Str)[This->Cur_pos] == 37)
			{
				Agg_result->Has_conv = 1;
				This->Cur_pos++;
				Llvm_lifetime_start_p0.Invoke(8L, &index);
				index = 0L;
				index = Parser_internal_ArgList_parse_index_rv6qzv.Invoke(This, &This->Cur_pos);
				Agg_result->Flags = Parser_internal_ArgList_parse_flags.Invoke(This, &This->Cur_pos);
				Agg_result->Min_width = 0;
				if (((sbyte*)This->Str)[This->Cur_pos] == 42)
				{
					This->Cur_pos++;
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk);
					sbyte* ptr = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_g66fk);
					*(int*)ptr = -1431655766;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = Parser_internal_ArgList_get_arg_value_int.Invoke(This, Parser_internal_ArgList_parse_index_rv6qzv.Invoke(This, &This->Cur_pos));
					*(long*)(&llvm_libc_20_1_2_cpp_optional_g66fk.Storage) = storage;
					if (!Optional_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk))
					{
						Agg_result->Has_conv = 0;
					}
					else
					{
						Agg_result->Min_width = Cpp_bit_cast_int_int.Invoke(Optional_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk));
					}
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk);
				}
				else if (Internal_isdigit_prmaet.Invoke(((sbyte*)This->Str)[This->Cur_pos]))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
					*(int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) = -1431655766;
					((int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -1431655766;
					((long*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)This->Str + This->Cur_pos, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					Llvm_libc_20_1_2_StrToNumResult_imtnam* num2 = &llvm_libc_20_1_2_StrToNumResult_imtnam;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num2 = struct_fiz2nb2.field_0;
					byte* num3 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb3.field_1;
					Agg_result->Min_width = llvm_libc_20_1_2_StrToNumResult_imtnam.Value;
					This->Cur_pos += llvm_libc_20_1_2_StrToNumResult_imtnam.Parsed_len;
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
				}
				if (Agg_result->Min_width < 0)
				{
					Agg_result->Min_width = ((Agg_result->Min_width != int.MinValue) ? checked(-Agg_result->Min_width) : int.MaxValue);
					Agg_result->Flags = (FormatFlags_hin2uh)((byte)Agg_result->Flags | 1);
				}
				Agg_result->Precision = -1;
				if (((sbyte*)This->Str)[This->Cur_pos] == 46)
				{
					This->Cur_pos++;
					Agg_result->Precision = 0;
					if (((sbyte*)This->Str)[This->Cur_pos] == 42)
					{
						This->Cur_pos++;
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk2);
						sbyte* ptr3 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_g66fk2);
						*(int*)ptr3 = -1431655766;
						ptr3[4] = -86;
						sbyte* ptr4 = ptr3 + 5;
						*ptr4 = -86;
						ptr4[1] = -86;
						ptr4[2] = -86;
						long storage2 = Parser_internal_ArgList_get_arg_value_int.Invoke(This, Parser_internal_ArgList_parse_index_rv6qzv.Invoke(This, &This->Cur_pos));
						*(long*)(&llvm_libc_20_1_2_cpp_optional_g66fk2.Storage) = storage2;
						if (!Optional_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk2))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Precision = Cpp_bit_cast_int_int.Invoke(Optional_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk2));
						}
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk2);
					}
					else if (Internal_isdigit_prmaet.Invoke(((sbyte*)This->Str)[This->Cur_pos]))
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam2);
						*(int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam2) = -1431655766;
						((int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam2))[1] = -1431655766;
						((long*)(&llvm_libc_20_1_2_StrToNumResult_imtnam2))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb4 = Internal_strtointeger_int.Invoke((byte*)This->Str + This->Cur_pos, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						Llvm_libc_20_1_2_StrToNumResult_imtnam* num4 = &llvm_libc_20_1_2_StrToNumResult_imtnam2;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num4 = struct_fiz2nb5.field_0;
						byte* num5 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_imtnam2) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num5 = struct_fiz2nb6.field_1;
						Agg_result->Precision = llvm_libc_20_1_2_StrToNumResult_imtnam2.Value;
						This->Cur_pos += llvm_libc_20_1_2_StrToNumResult_imtnam2.Parsed_len;
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam2);
					}
				}
				Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_LengthSpec);
				*(int*)(&llvm_libc_20_1_2_printf_core_LengthSpec) = -1431655766;
				sbyte* ptr5 = (sbyte*)(&llvm_libc_20_1_2_printf_core_LengthSpec) + 4;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				ptr5[3] = -86;
				((long*)(&llvm_libc_20_1_2_printf_core_LengthSpec))[1] = -6148914691236517206L;
				Struct_nfiam5 struct_nfiam = Parser_internal_ArgList_parse_length_modifier.Invoke(This, &This->Cur_pos);
				Llvm_libc_20_1_2_printf_core_LengthSpec* num6 = &llvm_libc_20_1_2_printf_core_LengthSpec;
				Struct_nfiam5 struct_nfiam2 = struct_nfiam;
				*(int*)num6 = struct_nfiam2.field_0;
				byte* num7 = (byte*)(&llvm_libc_20_1_2_printf_core_LengthSpec) + 8u;
				Struct_nfiam5 struct_nfiam3 = struct_nfiam;
				*(long*)num7 = struct_nfiam3.field_1;
				Agg_result->Length_modifier = llvm_libc_20_1_2_printf_core_LengthSpec.Lm;
				Agg_result->Conv_name = ((sbyte*)This->Str)[This->Cur_pos];
				Agg_result->Bit_width = llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width;
				switch (((sbyte*)This->Str)[This->Cur_pos])
				{
				case 37:
					Agg_result->Has_conv = 1;
					break;
				case 99:
				{
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk3);
					sbyte* ptr9 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_g66fk3);
					*(int*)ptr9 = -1431655766;
					ptr9[4] = -86;
					sbyte* ptr10 = ptr9 + 5;
					*ptr10 = -86;
					ptr10[1] = -86;
					ptr10[2] = -86;
					long storage3 = Parser_internal_ArgList_get_arg_value_int.Invoke(This, index);
					*(long*)(&llvm_libc_20_1_2_cpp_optional_g66fk3.Storage) = storage3;
					if (!Optional_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk3))
					{
						Agg_result->Has_conv = 0;
					}
					else
					{
						Agg_result->Conv_val_raw = Cpp_bit_cast_int_int.Invoke(Optional_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk3));
					}
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk3);
					break;
				}
				case 66:
				case 88:
				case 98:
				case 100:
				case 105:
				case 111:
				case 117:
				case 120:
					switch (llvm_libc_20_1_2_printf_core_LengthSpec.Lm)
					{
					case LengthModifier_mnvaa2.hh:
					case LengthModifier_mnvaa2.h:
					case LengthModifier_mnvaa2.none:
					{
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk4);
						sbyte* ptr38 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_g66fk4);
						*(int*)ptr38 = -1431655766;
						ptr38[4] = -86;
						sbyte* ptr39 = ptr38 + 5;
						*ptr39 = -86;
						ptr39[1] = -86;
						ptr39[2] = -86;
						long storage7 = Parser_internal_ArgList_get_arg_value_int.Invoke(This, index);
						*(long*)(&llvm_libc_20_1_2_cpp_optional_g66fk4.Storage) = storage7;
						if (!Optional_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk4))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = Cpp_bit_cast_int_int.Invoke(Optional_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk4));
						}
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk4);
						break;
					}
					case LengthModifier_mnvaa2.l:
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji);
						sbyte* ptr40 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji);
						*(long*)ptr40 = -6148914691236517206L;
						ptr40[8] = -86;
						sbyte* ptr41 = ptr40 + 9;
						*ptr41 = -86;
						ptr41[1] = -86;
						ptr41[2] = -86;
						ptr41[3] = -86;
						ptr41[4] = -86;
						ptr41[5] = -86;
						ptr41[6] = -86;
						Struct_8myw6y struct_8myw6y19 = Parser_internal_ArgList_get_arg_value_long.Invoke(This, index);
						Llvm_libc_20_1_2_cpp_expected* ptr42 = &llvm_libc_20_1_2_cpp_optional_d6hvji.Storage;
						Struct_8myw6y struct_8myw6y20 = struct_8myw6y19;
						((Struct_8myw6y*)ptr42)->field_0 = struct_8myw6y20.field_0;
						Struct_8myw6y struct_8myw6y21 = struct_8myw6y19;
						((Struct_8myw6y*)ptr42)->field_1 = struct_8myw6y21.field_1;
						if (!Optional_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = Cpp_bit_cast_long_long.Invoke(Optional_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji));
						}
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji);
						break;
					}
					case LengthModifier_mnvaa2.ll:
					case LengthModifier_mnvaa2.L:
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji2);
						sbyte* ptr35 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji2);
						*(long*)ptr35 = -6148914691236517206L;
						ptr35[8] = -86;
						sbyte* ptr36 = ptr35 + 9;
						*ptr36 = -86;
						ptr36[1] = -86;
						ptr36[2] = -86;
						ptr36[3] = -86;
						ptr36[4] = -86;
						ptr36[5] = -86;
						ptr36[6] = -86;
						Struct_8myw6y struct_8myw6y16 = Parser_internal_ArgList_get_arg_value_long_long.Invoke(This, index);
						Llvm_libc_20_1_2_cpp_expected* ptr37 = &llvm_libc_20_1_2_cpp_optional_d6hvji2.Storage;
						Struct_8myw6y struct_8myw6y17 = struct_8myw6y16;
						((Struct_8myw6y*)ptr37)->field_0 = struct_8myw6y17.field_0;
						Struct_8myw6y struct_8myw6y18 = struct_8myw6y16;
						((Struct_8myw6y*)ptr37)->field_1 = struct_8myw6y18.field_1;
						if (!Optional_long_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji2))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = Cpp_bit_cast_long_long_long_long.Invoke(Optional_long_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji2));
						}
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji2);
						break;
					}
					case LengthModifier_mnvaa2.j:
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji3);
						sbyte* ptr43 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji3);
						*(long*)ptr43 = -6148914691236517206L;
						ptr43[8] = -86;
						sbyte* ptr44 = ptr43 + 9;
						*ptr44 = -86;
						ptr44[1] = -86;
						ptr44[2] = -86;
						ptr44[3] = -86;
						ptr44[4] = -86;
						ptr44[5] = -86;
						ptr44[6] = -86;
						Struct_8myw6y struct_8myw6y22 = Parser_internal_ArgList_get_arg_value_long.Invoke(This, index);
						Llvm_libc_20_1_2_cpp_expected* ptr45 = &llvm_libc_20_1_2_cpp_optional_d6hvji3.Storage;
						Struct_8myw6y struct_8myw6y23 = struct_8myw6y22;
						((Struct_8myw6y*)ptr45)->field_0 = struct_8myw6y23.field_0;
						Struct_8myw6y struct_8myw6y24 = struct_8myw6y22;
						((Struct_8myw6y*)ptr45)->field_1 = struct_8myw6y24.field_1;
						if (!Optional_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji3))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = Cpp_bit_cast_long_long.Invoke(Optional_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji3));
						}
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji3);
						break;
					}
					case LengthModifier_mnvaa2.z:
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji4);
						sbyte* ptr46 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji4);
						*(long*)ptr46 = -6148914691236517206L;
						ptr46[8] = -86;
						sbyte* ptr47 = ptr46 + 9;
						*ptr47 = -86;
						ptr47[1] = -86;
						ptr47[2] = -86;
						ptr47[3] = -86;
						ptr47[4] = -86;
						ptr47[5] = -86;
						ptr47[6] = -86;
						Struct_8myw6y struct_8myw6y25 = Parser_internal_ArgList_get_arg_value_unsigned_long.Invoke(This, index);
						Llvm_libc_20_1_2_cpp_expected* ptr48 = &llvm_libc_20_1_2_cpp_optional_d6hvji4.Storage;
						Struct_8myw6y struct_8myw6y26 = struct_8myw6y25;
						((Struct_8myw6y*)ptr48)->field_0 = struct_8myw6y26.field_0;
						Struct_8myw6y struct_8myw6y27 = struct_8myw6y25;
						((Struct_8myw6y*)ptr48)->field_1 = struct_8myw6y27.field_1;
						if (!Optional_unsigned_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji4))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = (Int128)(UInt128)(ulong)Cpp_bit_cast_unsigned_long_unsigned_long.Invoke(Optional_unsigned_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji4));
						}
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji4);
						break;
					}
					case LengthModifier_mnvaa2.t:
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji5);
						sbyte* ptr32 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji5);
						*(long*)ptr32 = -6148914691236517206L;
						ptr32[8] = -86;
						sbyte* ptr33 = ptr32 + 9;
						*ptr33 = -86;
						ptr33[1] = -86;
						ptr33[2] = -86;
						ptr33[3] = -86;
						ptr33[4] = -86;
						ptr33[5] = -86;
						ptr33[6] = -86;
						Struct_8myw6y struct_8myw6y13 = Parser_internal_ArgList_get_arg_value_long.Invoke(This, index);
						Llvm_libc_20_1_2_cpp_expected* ptr34 = &llvm_libc_20_1_2_cpp_optional_d6hvji5.Storage;
						Struct_8myw6y struct_8myw6y14 = struct_8myw6y13;
						((Struct_8myw6y*)ptr34)->field_0 = struct_8myw6y14.field_0;
						Struct_8myw6y struct_8myw6y15 = struct_8myw6y13;
						((Struct_8myw6y*)ptr34)->field_1 = struct_8myw6y15.field_1;
						if (!Optional_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji5))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = Cpp_bit_cast_long_long.Invoke(Optional_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji5));
						}
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji5);
						break;
					}
					case LengthModifier_mnvaa2.w:
					case LengthModifier_mnvaa2.wf:
						if (llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width == 0L)
						{
							Agg_result->Has_conv = 0;
						}
						else if ((ulong)llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width <= 32uL)
						{
							Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk5);
							sbyte* ptr21 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_g66fk5);
							*(int*)ptr21 = -1431655766;
							ptr21[4] = -86;
							sbyte* ptr22 = ptr21 + 5;
							*ptr22 = -86;
							ptr22[1] = -86;
							ptr22[2] = -86;
							long storage6 = Parser_internal_ArgList_get_arg_value_int.Invoke(This, index);
							*(long*)(&llvm_libc_20_1_2_cpp_optional_g66fk5.Storage) = storage6;
							if (!Optional_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk5))
							{
								Agg_result->Has_conv = 0;
							}
							else
							{
								Agg_result->Conv_val_raw = Cpp_bit_cast_int_int.Invoke(Optional_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk5));
							}
							Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk5);
						}
						else if ((ulong)llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width <= 64uL)
						{
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji6);
							sbyte* ptr23 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji6);
							*(long*)ptr23 = -6148914691236517206L;
							ptr23[8] = -86;
							sbyte* ptr24 = ptr23 + 9;
							*ptr24 = -86;
							ptr24[1] = -86;
							ptr24[2] = -86;
							ptr24[3] = -86;
							ptr24[4] = -86;
							ptr24[5] = -86;
							ptr24[6] = -86;
							Struct_8myw6y struct_8myw6y4 = Parser_internal_ArgList_get_arg_value_long.Invoke(This, index);
							Llvm_libc_20_1_2_cpp_expected* ptr25 = &llvm_libc_20_1_2_cpp_optional_d6hvji6.Storage;
							Struct_8myw6y struct_8myw6y5 = struct_8myw6y4;
							((Struct_8myw6y*)ptr25)->field_0 = struct_8myw6y5.field_0;
							Struct_8myw6y struct_8myw6y6 = struct_8myw6y4;
							((Struct_8myw6y*)ptr25)->field_1 = struct_8myw6y6.field_1;
							if (!Optional_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji6))
							{
								Agg_result->Has_conv = 0;
							}
							else
							{
								Agg_result->Conv_val_raw = Cpp_bit_cast_long_long.Invoke(Optional_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji6));
							}
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji6);
						}
						else if ((ulong)llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width <= 64uL)
						{
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji7);
							sbyte* ptr26 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji7);
							*(long*)ptr26 = -6148914691236517206L;
							ptr26[8] = -86;
							sbyte* ptr27 = ptr26 + 9;
							*ptr27 = -86;
							ptr27[1] = -86;
							ptr27[2] = -86;
							ptr27[3] = -86;
							ptr27[4] = -86;
							ptr27[5] = -86;
							ptr27[6] = -86;
							Struct_8myw6y struct_8myw6y7 = Parser_internal_ArgList_get_arg_value_long_long.Invoke(This, index);
							Llvm_libc_20_1_2_cpp_expected* ptr28 = &llvm_libc_20_1_2_cpp_optional_d6hvji7.Storage;
							Struct_8myw6y struct_8myw6y8 = struct_8myw6y7;
							((Struct_8myw6y*)ptr28)->field_0 = struct_8myw6y8.field_0;
							Struct_8myw6y struct_8myw6y9 = struct_8myw6y7;
							((Struct_8myw6y*)ptr28)->field_1 = struct_8myw6y9.field_1;
							if (!Optional_long_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji7))
							{
								Agg_result->Has_conv = 0;
							}
							else
							{
								Agg_result->Conv_val_raw = Cpp_bit_cast_long_long_long_long.Invoke(Optional_long_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji7));
							}
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji7);
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji8);
							sbyte* ptr29 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji8);
							*(long*)ptr29 = -6148914691236517206L;
							ptr29[8] = -86;
							sbyte* ptr30 = ptr29 + 9;
							*ptr30 = -86;
							ptr30[1] = -86;
							ptr30[2] = -86;
							ptr30[3] = -86;
							ptr30[4] = -86;
							ptr30[5] = -86;
							ptr30[6] = -86;
							Struct_8myw6y struct_8myw6y10 = Parser_internal_ArgList_get_arg_value_long.Invoke(This, index);
							Llvm_libc_20_1_2_cpp_expected* ptr31 = &llvm_libc_20_1_2_cpp_optional_d6hvji8.Storage;
							Struct_8myw6y struct_8myw6y11 = struct_8myw6y10;
							((Struct_8myw6y*)ptr31)->field_0 = struct_8myw6y11.field_0;
							Struct_8myw6y struct_8myw6y12 = struct_8myw6y10;
							((Struct_8myw6y*)ptr31)->field_1 = struct_8myw6y12.field_1;
							if (!Optional_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji8))
							{
								Agg_result->Has_conv = 0;
							}
							else
							{
								Agg_result->Conv_val_raw = Cpp_bit_cast_long_long.Invoke(Optional_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji8));
							}
							Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji8);
						}
						break;
					}
					break;
				case 65:
				case 69:
				case 70:
				case 71:
				case 97:
				case 101:
				case 102:
				case 103:
				{
					if (llvm_libc_20_1_2_printf_core_LengthSpec.Lm != LengthModifier_mnvaa2.L)
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq);
						sbyte* ptr49 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_vhbvq);
						*(double*)ptr49 = double.NaN;
						ptr49[8] = -86;
						sbyte* ptr50 = ptr49 + 9;
						*ptr50 = -86;
						ptr50[1] = -86;
						ptr50[2] = -86;
						ptr50[3] = -86;
						ptr50[4] = -86;
						ptr50[5] = -86;
						ptr50[6] = -86;
						Struct_8myw6y struct_8myw6y28 = Parser_internal_ArgList_get_arg_value_double.Invoke(This, index);
						Llvm_libc_20_1_2_cpp_optional_double_OptionalStorage* ptr51 = &llvm_libc_20_1_2_cpp_optional_vhbvq.Storage;
						Struct_8myw6y struct_8myw6y29 = struct_8myw6y28;
						((Struct_8myw6y*)ptr51)->field_0 = struct_8myw6y29.field_0;
						Struct_8myw6y struct_8myw6y30 = struct_8myw6y28;
						((Struct_8myw6y*)ptr51)->field_1 = struct_8myw6y30.field_1;
						if (!Optional_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = (Int128)(UInt128)(ulong)Cpp_bit_cast_unsigned_long_double.Invoke(Optional_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_vhbvq));
						}
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_vhbvq);
						break;
					}
					Llvm_lifetime_start_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_optional_59q3zq);
					sbyte* ptr52 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_59q3zq);
					*(double*)ptr52 = double.NaN;
					ptr52[16] = -86;
					sbyte* ptr53 = ptr52 + 17;
					*ptr53 = -86;
					ptr53[1] = -86;
					ptr53[2] = -86;
					ptr53[3] = -86;
					ptr53[4] = -86;
					ptr53[5] = -86;
					ptr53[6] = -86;
					ptr53[7] = -86;
					ptr53[8] = -86;
					ptr53[9] = -86;
					ptr53[10] = -86;
					ptr53[11] = -86;
					ptr53[12] = -86;
					ptr53[13] = -86;
					ptr53[14] = -86;
					Parser_internal_ArgList_get_arg_value_long_double.Invoke(&llvm_libc_20_1_2_cpp_optional_59q3zq, This, index);
					if (!Optional_long_double_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_59q3zq))
					{
						Agg_result->Has_conv = 0;
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb7 = Cpp_bit_cast_unsigned_int128_long_double.Invoke(Optional_long_double_value.Invoke(&llvm_libc_20_1_2_cpp_optional_59q3zq));
						Int128* num8 = &conv_val_raw;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						*(long*)num8 = struct_fiz2nb8.field_0;
						byte* num9 = (byte*)(&conv_val_raw) + 8u;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						*(long*)num9 = struct_fiz2nb9.field_1;
						Agg_result->Conv_val_raw = conv_val_raw;
					}
					Llvm_lifetime_end_p0.Invoke(32L, &llvm_libc_20_1_2_cpp_optional_59q3zq);
					break;
				}
				case 82:
				case 114:
				{
					Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk6);
					sbyte* ptr11 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_g66fk6);
					*(int*)ptr11 = -1431655766;
					ptr11[4] = -86;
					sbyte* ptr12 = ptr11 + 5;
					*ptr12 = -86;
					ptr12[1] = -86;
					ptr12[2] = -86;
					long storage4 = Parser_internal_ArgList_get_arg_value_unsigned_int.Invoke(This, index);
					*(long*)(&llvm_libc_20_1_2_cpp_optional_g66fk6.Storage) = storage4;
					if (!Optional_unsigned_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk6))
					{
						Agg_result->Has_conv = 0;
					}
					else
					{
						Agg_result->Conv_val_raw = (Int128)(UInt128)(uint)Cpp_bit_cast_unsigned_int_unsigned_int.Invoke(Optional_unsigned_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk6));
					}
					Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk6);
					break;
				}
				case 75:
				case 107:
					if (llvm_libc_20_1_2_printf_core_LengthSpec.Lm == LengthModifier_mnvaa2.l)
					{
						Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji9);
						sbyte* ptr13 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_d6hvji9);
						*(long*)ptr13 = -6148914691236517206L;
						ptr13[8] = -86;
						sbyte* ptr14 = ptr13 + 9;
						*ptr14 = -86;
						ptr14[1] = -86;
						ptr14[2] = -86;
						ptr14[3] = -86;
						ptr14[4] = -86;
						ptr14[5] = -86;
						ptr14[6] = -86;
						Struct_8myw6y struct_8myw6y = Parser_internal_ArgList_get_arg_value_unsigned_long.Invoke(This, index);
						Llvm_libc_20_1_2_cpp_expected* ptr15 = &llvm_libc_20_1_2_cpp_optional_d6hvji9.Storage;
						Struct_8myw6y struct_8myw6y2 = struct_8myw6y;
						((Struct_8myw6y*)ptr15)->field_0 = struct_8myw6y2.field_0;
						Struct_8myw6y struct_8myw6y3 = struct_8myw6y;
						((Struct_8myw6y*)ptr15)->field_1 = struct_8myw6y3.field_1;
						if (!Optional_unsigned_long_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji9))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = (Int128)(UInt128)(ulong)Cpp_bit_cast_unsigned_long_unsigned_long.Invoke(Optional_unsigned_long_value.Invoke(&llvm_libc_20_1_2_cpp_optional_d6hvji9));
						}
						Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_d6hvji9);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk7);
						sbyte* ptr16 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_g66fk7);
						*(int*)ptr16 = -1431655766;
						ptr16[4] = -86;
						sbyte* ptr17 = ptr16 + 5;
						*ptr17 = -86;
						ptr17[1] = -86;
						ptr17[2] = -86;
						long storage5 = Parser_internal_ArgList_get_arg_value_unsigned_int.Invoke(This, index);
						*(long*)(&llvm_libc_20_1_2_cpp_optional_g66fk7.Storage) = storage5;
						if (!Optional_unsigned_int_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk7))
						{
							Agg_result->Has_conv = 0;
						}
						else
						{
							Agg_result->Conv_val_raw = (Int128)(UInt128)(uint)Cpp_bit_cast_unsigned_int_unsigned_int.Invoke(Optional_unsigned_int_value.Invoke(&llvm_libc_20_1_2_cpp_optional_g66fk7));
						}
						Llvm_lifetime_end_p0.Invoke(8L, &llvm_libc_20_1_2_cpp_optional_g66fk7);
					}
					break;
				case 109:
					Agg_result->Conv_val_raw = Errno_ToInt32.Invoke(Llvm_libc_20_1_2_libc_errno.Pointer);
					break;
				case 110:
				case 112:
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_77yu8f);
					sbyte* ptr18 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_77yu8f);
					*(IntPtr*)ptr18 = unchecked((nint)(-6148914691236517206L));
					ptr18[8] = -86;
					sbyte* ptr19 = ptr18 + 9;
					*ptr19 = -86;
					ptr19[1] = -86;
					ptr19[2] = -86;
					ptr19[3] = -86;
					ptr19[4] = -86;
					ptr19[5] = -86;
					ptr19[6] = -86;
					Struct_yx4nca struct_yx4nca4 = Parser_internal_ArgList_get_arg_value_void.Invoke(This, index);
					Llvm_libc_20_1_2_cpp_optional_char_OptionalStorage* ptr20 = &llvm_libc_20_1_2_cpp_optional_77yu8f.Storage;
					Struct_yx4nca struct_yx4nca5 = struct_yx4nca4;
					((Struct_yx4nca*)ptr20)->field_0 = struct_yx4nca5.field_0;
					Struct_yx4nca struct_yx4nca6 = struct_yx4nca4;
					((Struct_yx4nca*)ptr20)->field_1 = struct_yx4nca6.field_1;
					if (!Optional_void_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f))
					{
						Agg_result->Has_conv = 0;
					}
					else
					{
						Agg_result->Conv_val_ptr = Cpp_bit_cast_void_void.Invoke(Optional_void_value.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f));
					}
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_77yu8f);
					break;
				}
				case 115:
				{
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_77yu8f2);
					sbyte* ptr6 = (sbyte*)(&llvm_libc_20_1_2_cpp_optional_77yu8f2);
					*(IntPtr*)ptr6 = unchecked((nint)(-6148914691236517206L));
					ptr6[8] = -86;
					sbyte* ptr7 = ptr6 + 9;
					*ptr7 = -86;
					ptr7[1] = -86;
					ptr7[2] = -86;
					ptr7[3] = -86;
					ptr7[4] = -86;
					ptr7[5] = -86;
					ptr7[6] = -86;
					Struct_yx4nca struct_yx4nca = Parser_internal_ArgList_get_arg_value_char.Invoke(This, index);
					Llvm_libc_20_1_2_cpp_optional_char_OptionalStorage* ptr8 = &llvm_libc_20_1_2_cpp_optional_77yu8f2.Storage;
					Struct_yx4nca struct_yx4nca2 = struct_yx4nca;
					((Struct_yx4nca*)ptr8)->field_0 = struct_yx4nca2.field_0;
					Struct_yx4nca struct_yx4nca3 = struct_yx4nca;
					((Struct_yx4nca*)ptr8)->field_1 = struct_yx4nca3.field_1;
					if (!Optional_char_has_value.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f2))
					{
						Agg_result->Has_conv = 0;
					}
					else
					{
						Agg_result->Conv_val_ptr = Cpp_bit_cast_char_char.Invoke(Optional_char_value.Invoke(&llvm_libc_20_1_2_cpp_optional_77yu8f2));
					}
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_optional_77yu8f2);
					break;
				}
				default:
					Agg_result->Has_conv = 0;
					break;
				}
				if (((sbyte*)This->Str)[This->Cur_pos] != 0)
				{
					This->Cur_pos++;
				}
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_printf_core_LengthSpec);
				Llvm_lifetime_end_p0.Invoke(8L, &index);
			}
			else
			{
				Agg_result->Has_conv = 0;
				while (((sbyte*)This->Str)[This->Cur_pos] != 37 && ((sbyte*)This->Str)[This->Cur_pos] != 0)
				{
					This->Cur_pos++;
				}
			}
			Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			String_view_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, (byte*)This->Str + num, This->Cur_pos - num);
			Llvm_memcpy_p0_p0_i64.Invoke(&Agg_result->Raw_string, &llvm_libc_20_1_2_cpp_string_view, 16L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
