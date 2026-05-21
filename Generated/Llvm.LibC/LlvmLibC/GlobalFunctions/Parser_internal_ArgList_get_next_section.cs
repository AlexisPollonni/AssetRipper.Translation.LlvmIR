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
	public unsafe static void Invoke([MangledName("agg.result")] scanf_core_FormatSection* agg_result, scanf_core_Parser* @this)
	{
		long num = 0L;
		long num2 = 0L;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		int num3 = 0;
		sbyte b = 0;
		sbyte b2 = 0;
		sbyte b3 = 0;
		cpp_array_jgy3xh cpp_array_jgy3xh2 = default(cpp_array_jgy3xh);
		sbyte b4 = 0;
		long num4 = 0L;
		sbyte b5 = 0;
		sbyte b6 = 0;
		sbyte b7 = 0;
		sbyte b8 = 0;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		llvm_memset_p0_i64.Invoke(agg_result, -86, 88L, isVolatile: false);
		FormatSection_Constructor_ea9nd2.Invoke(agg_result);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = @this->cur_pos;
		unchecked
		{
			if (((sbyte*)@this->str)[@this->cur_pos] == 37)
			{
				agg_result->has_conv = 1;
				@this->cur_pos++;
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				num2 = Parser_internal_ArgList_parse_index_uewqxq.Invoke(@this, &@this->cur_pos);
				if (((sbyte*)@this->str)[@this->cur_pos] == 42)
				{
					@this->cur_pos++;
					agg_result->flags = FormatFlags_96pze4.NO_WRITE;
				}
				agg_result->max_width = -1;
				if (internal_isdigit_gvvitd.Invoke(((sbyte*)@this->str)[@this->cur_pos]))
				{
					llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
					*(int*)(&strToNumResult_imtnam) = -1431655766;
					((int*)(&strToNumResult_imtnam))[1] = -1431655766;
					((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = internal_strtointeger_int.Invoke((byte*)@this->str + @this->cur_pos, 10, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					StrToNumResult_imtnam* num5 = &strToNumResult_imtnam;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num5 = struct_fiz2nb2.field_0;
					byte* num6 = (byte*)(&strToNumResult_imtnam) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num6 = struct_fiz2nb3.field_1;
					agg_result->max_width = strToNumResult_imtnam.value;
					@this->cur_pos += strToNumResult_imtnam.parsed_len;
					llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = (int)(agg_result->length_modifier = Parser_internal_ArgList_parse_length_modifier.Invoke(@this, &@this->cur_pos));
				agg_result->conv_name = ((sbyte*)@this->str)[@this->cur_pos];
				if (((byte)agg_result->flags & 1) == 0)
				{
					agg_result->output_ptr = Parser_internal_ArgList_get_arg_value_void.Invoke(@this, num2);
				}
				if (((sbyte*)@this->str)[@this->cur_pos] != 0)
				{
					@this->cur_pos++;
				}
				else
				{
					agg_result->has_conv = 0;
				}
				if (agg_result->conv_name == 91)
				{
					llvm_lifetime_start_p0.Invoke(1L, &b);
					b = 93;
					llvm_lifetime_start_p0.Invoke(1L, &b2);
					b2 = 94;
					llvm_lifetime_start_p0.Invoke(1L, &b3);
					b3 = 45;
					llvm_lifetime_start_p0.Invoke(32L, &cpp_array_jgy3xh2);
					sbyte* ptr = (sbyte*)(&cpp_array_jgy3xh2);
					*(long*)ptr = -6148914691236517206L;
					((long*)ptr)[1] = -6148914691236517206L;
					((long*)ptr)[2] = -6148914691236517206L;
					((long*)ptr)[3] = -6148914691236517206L;
					bitset_256ul_Constructor.Invoke(&cpp_array_jgy3xh2);
					llvm_lifetime_start_p0.Invoke(1L, &b4);
					b4 = 0;
					if (((sbyte*)@this->str)[@this->cur_pos] == 94)
					{
						b4 = 1;
						@this->cur_pos++;
					}
					llvm_lifetime_start_p0.Invoke(8L, &num4);
					num4 = @this->cur_pos;
					if (((sbyte*)@this->str)[@this->cur_pos] == 93)
					{
						bitset_256ul_set.Invoke(&cpp_array_jgy3xh2, 93L);
						@this->cur_pos++;
					}
					while (((sbyte*)@this->str)[@this->cur_pos] != 0 && ((sbyte*)@this->str)[@this->cur_pos] != 93)
					{
						if (((sbyte*)@this->str)[@this->cur_pos] == 45 && @this->cur_pos != num4 && ((sbyte*)@this->str)[@this->cur_pos + 1L] != 93 && ((sbyte*)@this->str)[@this->cur_pos + 1L] != 0)
						{
							llvm_lifetime_start_p0.Invoke(1L, &b5);
							b5 = ((sbyte*)@this->str)[@this->cur_pos - 1L];
							llvm_lifetime_start_p0.Invoke(1L, &b6);
							b6 = ((sbyte*)@this->str)[@this->cur_pos + 1L];
							llvm_lifetime_start_p0.Invoke(1L, &b7);
							b7 = ((b5 >= b6) ? b6 : b5);
							llvm_lifetime_start_p0.Invoke(1L, &b8);
							b8 = ((b5 >= b6) ? b5 : b6);
							bitset_256ul_set_range.Invoke(&cpp_array_jgy3xh2, b7, b8);
							@this->cur_pos += 2L;
							llvm_lifetime_end_p0.Invoke(1L, &b8);
							llvm_lifetime_end_p0.Invoke(1L, &b7);
							llvm_lifetime_end_p0.Invoke(1L, &b6);
							llvm_lifetime_end_p0.Invoke(1L, &b5);
						}
						else
						{
							bitset_256ul_set.Invoke(&cpp_array_jgy3xh2, ((sbyte*)@this->str)[@this->cur_pos]);
							@this->cur_pos++;
						}
					}
					if ((b4 & 1) == 1)
					{
						bitset_256ul_flip.Invoke(&cpp_array_jgy3xh2);
					}
					if (((sbyte*)@this->str)[@this->cur_pos] == 93)
					{
						@this->cur_pos++;
						llvm_memcpy_p0_p0_i64.Invoke(&agg_result->scan_set, &cpp_array_jgy3xh2, 32L, isVolatile: false);
					}
					else
					{
						agg_result->has_conv = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num4);
					llvm_lifetime_end_p0.Invoke(1L, &b4);
					llvm_lifetime_end_p0.Invoke(32L, &cpp_array_jgy3xh2);
					llvm_lifetime_end_p0.Invoke(1L, &b3);
					llvm_lifetime_end_p0.Invoke(1L, &b2);
					llvm_lifetime_end_p0.Invoke(1L, &b);
				}
				llvm_lifetime_end_p0.Invoke(4L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			else
			{
				agg_result->has_conv = 0;
				while (((sbyte*)@this->str)[@this->cur_pos] != 37 && ((sbyte*)@this->str)[@this->cur_pos] != 0)
				{
					@this->cur_pos++;
				}
			}
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
			string_view_Constructor.Invoke(&cpp_string_view2, (byte*)@this->str + num, @this->cur_pos - num);
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->raw_string, &cpp_string_view2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE16get_next_sectionEv")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_section()")]
	public unsafe static void Invoke([MangledName("agg.result")] printf_core_FormatSection* agg_result, printf_core_Parser* @this)
	{
		long num = 0L;
		long num2 = 0L;
		cpp_optional_g66fk4 cpp_optional_g66fk5 = default(cpp_optional_g66fk4);
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		cpp_optional_g66fk4 cpp_optional_g66fk6 = default(cpp_optional_g66fk4);
		StrToNumResult_imtnam strToNumResult_imtnam2 = default(StrToNumResult_imtnam);
		printf_core_LengthSpec printf_core_LengthSpec2 = default(printf_core_LengthSpec);
		cpp_optional_g66fk4 cpp_optional_g66fk7 = default(cpp_optional_g66fk4);
		cpp_optional_g66fk4 cpp_optional_g66fk8 = default(cpp_optional_g66fk4);
		cpp_optional_d6hvji cpp_optional_d6hvji2 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji3 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji4 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji5 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji6 = default(cpp_optional_d6hvji);
		cpp_optional_g66fk4 cpp_optional_g66fk9 = default(cpp_optional_g66fk4);
		cpp_optional_d6hvji cpp_optional_d6hvji7 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji8 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji9 = default(cpp_optional_d6hvji);
		cpp_optional_vhbvq7 cpp_optional_vhbvq8 = default(cpp_optional_vhbvq7);
		cpp_optional_59q3zq cpp_optional_59q3zq2 = default(cpp_optional_59q3zq);
		Int128 conv_val_raw = default(Int128);
		cpp_optional_g66fk4 cpp_optional_g66fk10 = default(cpp_optional_g66fk4);
		cpp_optional_d6hvji cpp_optional_d6hvji10 = default(cpp_optional_d6hvji);
		cpp_optional_g66fk4 cpp_optional_g66fk11 = default(cpp_optional_g66fk4);
		cpp_optional_77yu8f cpp_optional_77yu8f2 = default(cpp_optional_77yu8f);
		cpp_optional_77yu8f cpp_optional_77yu8f3 = default(cpp_optional_77yu8f);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		llvm_memset_p0_i64.Invoke(agg_result, -86, 80L, isVolatile: false);
		FormatSection_Constructor_fn7xv9.Invoke(agg_result);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = @this->cur_pos;
		unchecked
		{
			if (((sbyte*)@this->str)[@this->cur_pos] == 37)
			{
				agg_result->has_conv = 1;
				@this->cur_pos++;
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = 0L;
				num2 = Parser_internal_ArgList_parse_index_rv6qzv.Invoke(@this, &@this->cur_pos);
				agg_result->flags = Parser_internal_ArgList_parse_flags.Invoke(@this, &@this->cur_pos);
				agg_result->min_width = 0;
				if (((sbyte*)@this->str)[@this->cur_pos] == 42)
				{
					@this->cur_pos++;
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk5);
					sbyte* ptr = (sbyte*)(&cpp_optional_g66fk5);
					*(int*)ptr = -1431655766;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = Parser_internal_ArgList_get_arg_value_int.Invoke(@this, Parser_internal_ArgList_parse_index_rv6qzv.Invoke(@this, &@this->cur_pos));
					*(long*)(&cpp_optional_g66fk5.storage) = storage;
					if (!optional_int_has_value.Invoke(&cpp_optional_g66fk5))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->min_width = cpp_bit_cast_int_int.Invoke(optional_int_value.Invoke(&cpp_optional_g66fk5));
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk5);
				}
				else if (internal_isdigit_prmaet.Invoke(((sbyte*)@this->str)[@this->cur_pos]))
				{
					llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
					*(int*)(&strToNumResult_imtnam) = -1431655766;
					((int*)(&strToNumResult_imtnam))[1] = -1431655766;
					((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = internal_strtointeger_int.Invoke((byte*)@this->str + @this->cur_pos, 10, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					StrToNumResult_imtnam* num3 = &strToNumResult_imtnam;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb2.field_0;
					byte* num4 = (byte*)(&strToNumResult_imtnam) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num4 = struct_fiz2nb3.field_1;
					agg_result->min_width = strToNumResult_imtnam.value;
					@this->cur_pos += strToNumResult_imtnam.parsed_len;
					llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
				}
				if (agg_result->min_width < 0)
				{
					agg_result->min_width = ((agg_result->min_width != int.MinValue) ? checked(-agg_result->min_width) : int.MaxValue);
					agg_result->flags = (FormatFlags_hin2uh)((byte)agg_result->flags | 1);
				}
				agg_result->precision = -1;
				if (((sbyte*)@this->str)[@this->cur_pos] == 46)
				{
					@this->cur_pos++;
					agg_result->precision = 0;
					if (((sbyte*)@this->str)[@this->cur_pos] == 42)
					{
						@this->cur_pos++;
						llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk6);
						sbyte* ptr3 = (sbyte*)(&cpp_optional_g66fk6);
						*(int*)ptr3 = -1431655766;
						ptr3[4] = -86;
						sbyte* ptr4 = ptr3 + 5;
						*ptr4 = -86;
						ptr4[1] = -86;
						ptr4[2] = -86;
						long storage2 = Parser_internal_ArgList_get_arg_value_int.Invoke(@this, Parser_internal_ArgList_parse_index_rv6qzv.Invoke(@this, &@this->cur_pos));
						*(long*)(&cpp_optional_g66fk6.storage) = storage2;
						if (!optional_int_has_value.Invoke(&cpp_optional_g66fk6))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->precision = cpp_bit_cast_int_int.Invoke(optional_int_value.Invoke(&cpp_optional_g66fk6));
						}
						llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk6);
					}
					else if (internal_isdigit_prmaet.Invoke(((sbyte*)@this->str)[@this->cur_pos]))
					{
						llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam2);
						*(int*)(&strToNumResult_imtnam2) = -1431655766;
						((int*)(&strToNumResult_imtnam2))[1] = -1431655766;
						((long*)(&strToNumResult_imtnam2))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb4 = internal_strtointeger_int.Invoke((byte*)@this->str + @this->cur_pos, 10, integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_imtnam* num5 = &strToNumResult_imtnam2;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num5 = struct_fiz2nb5.field_0;
						byte* num6 = (byte*)(&strToNumResult_imtnam2) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num6 = struct_fiz2nb6.field_1;
						agg_result->precision = strToNumResult_imtnam2.value;
						@this->cur_pos += strToNumResult_imtnam2.parsed_len;
						llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam2);
					}
				}
				llvm_lifetime_start_p0.Invoke(16L, &printf_core_LengthSpec2);
				*(int*)(&printf_core_LengthSpec2) = -1431655766;
				sbyte* ptr5 = (sbyte*)(&printf_core_LengthSpec2) + 4;
				*ptr5 = -86;
				ptr5[1] = -86;
				ptr5[2] = -86;
				ptr5[3] = -86;
				((long*)(&printf_core_LengthSpec2))[1] = -6148914691236517206L;
				Struct_nfiam5 struct_nfiam = Parser_internal_ArgList_parse_length_modifier.Invoke(@this, &@this->cur_pos);
				printf_core_LengthSpec* num7 = &printf_core_LengthSpec2;
				Struct_nfiam5 struct_nfiam2 = struct_nfiam;
				*(int*)num7 = struct_nfiam2.field_0;
				byte* num8 = (byte*)(&printf_core_LengthSpec2) + 8u;
				Struct_nfiam5 struct_nfiam3 = struct_nfiam;
				*(long*)num8 = struct_nfiam3.field_1;
				agg_result->length_modifier = printf_core_LengthSpec2.lm;
				agg_result->conv_name = ((sbyte*)@this->str)[@this->cur_pos];
				agg_result->bit_width = printf_core_LengthSpec2.bit_width;
				switch (((sbyte*)@this->str)[@this->cur_pos])
				{
				case 37:
					agg_result->has_conv = 1;
					break;
				case 99:
				{
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk7);
					sbyte* ptr9 = (sbyte*)(&cpp_optional_g66fk7);
					*(int*)ptr9 = -1431655766;
					ptr9[4] = -86;
					sbyte* ptr10 = ptr9 + 5;
					*ptr10 = -86;
					ptr10[1] = -86;
					ptr10[2] = -86;
					long storage3 = Parser_internal_ArgList_get_arg_value_int.Invoke(@this, num2);
					*(long*)(&cpp_optional_g66fk7.storage) = storage3;
					if (!optional_int_has_value.Invoke(&cpp_optional_g66fk7))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->conv_val_raw = cpp_bit_cast_int_int.Invoke(optional_int_value.Invoke(&cpp_optional_g66fk7));
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk7);
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
					switch (printf_core_LengthSpec2.lm)
					{
					case LengthModifier_mnvaa2.hh:
					case LengthModifier_mnvaa2.h:
					case LengthModifier_mnvaa2.none:
					{
						llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk8);
						sbyte* ptr38 = (sbyte*)(&cpp_optional_g66fk8);
						*(int*)ptr38 = -1431655766;
						ptr38[4] = -86;
						sbyte* ptr39 = ptr38 + 5;
						*ptr39 = -86;
						ptr39[1] = -86;
						ptr39[2] = -86;
						long storage7 = Parser_internal_ArgList_get_arg_value_int.Invoke(@this, num2);
						*(long*)(&cpp_optional_g66fk8.storage) = storage7;
						if (!optional_int_has_value.Invoke(&cpp_optional_g66fk8))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_bit_cast_int_int.Invoke(optional_int_value.Invoke(&cpp_optional_g66fk8));
						}
						llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk8);
						break;
					}
					case LengthModifier_mnvaa2.l:
					{
						llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji2);
						sbyte* ptr40 = (sbyte*)(&cpp_optional_d6hvji2);
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
						Struct_8myw6y struct_8myw6y19 = Parser_internal_ArgList_get_arg_value_long.Invoke(@this, num2);
						cpp_expected* ptr42 = &cpp_optional_d6hvji2.storage;
						Struct_8myw6y struct_8myw6y20 = struct_8myw6y19;
						((Struct_8myw6y*)ptr42)->field_0 = struct_8myw6y20.field_0;
						Struct_8myw6y struct_8myw6y21 = struct_8myw6y19;
						((Struct_8myw6y*)ptr42)->field_1 = struct_8myw6y21.field_1;
						if (!optional_long_has_value.Invoke(&cpp_optional_d6hvji2))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_bit_cast_long_long.Invoke(optional_long_value.Invoke(&cpp_optional_d6hvji2));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji2);
						break;
					}
					case LengthModifier_mnvaa2.ll:
					case LengthModifier_mnvaa2.L:
					{
						llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji3);
						sbyte* ptr35 = (sbyte*)(&cpp_optional_d6hvji3);
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
						Struct_8myw6y struct_8myw6y16 = Parser_internal_ArgList_get_arg_value_long_long.Invoke(@this, num2);
						cpp_expected* ptr37 = &cpp_optional_d6hvji3.storage;
						Struct_8myw6y struct_8myw6y17 = struct_8myw6y16;
						((Struct_8myw6y*)ptr37)->field_0 = struct_8myw6y17.field_0;
						Struct_8myw6y struct_8myw6y18 = struct_8myw6y16;
						((Struct_8myw6y*)ptr37)->field_1 = struct_8myw6y18.field_1;
						if (!optional_long_long_has_value.Invoke(&cpp_optional_d6hvji3))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_bit_cast_long_long_long_long.Invoke(optional_long_long_value.Invoke(&cpp_optional_d6hvji3));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji3);
						break;
					}
					case LengthModifier_mnvaa2.j:
					{
						llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji4);
						sbyte* ptr43 = (sbyte*)(&cpp_optional_d6hvji4);
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
						Struct_8myw6y struct_8myw6y22 = Parser_internal_ArgList_get_arg_value_long.Invoke(@this, num2);
						cpp_expected* ptr45 = &cpp_optional_d6hvji4.storage;
						Struct_8myw6y struct_8myw6y23 = struct_8myw6y22;
						((Struct_8myw6y*)ptr45)->field_0 = struct_8myw6y23.field_0;
						Struct_8myw6y struct_8myw6y24 = struct_8myw6y22;
						((Struct_8myw6y*)ptr45)->field_1 = struct_8myw6y24.field_1;
						if (!optional_long_has_value.Invoke(&cpp_optional_d6hvji4))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_bit_cast_long_long.Invoke(optional_long_value.Invoke(&cpp_optional_d6hvji4));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji4);
						break;
					}
					case LengthModifier_mnvaa2.z:
					{
						llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji5);
						sbyte* ptr46 = (sbyte*)(&cpp_optional_d6hvji5);
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
						Struct_8myw6y struct_8myw6y25 = Parser_internal_ArgList_get_arg_value_unsigned_long.Invoke(@this, num2);
						cpp_expected* ptr48 = &cpp_optional_d6hvji5.storage;
						Struct_8myw6y struct_8myw6y26 = struct_8myw6y25;
						((Struct_8myw6y*)ptr48)->field_0 = struct_8myw6y26.field_0;
						Struct_8myw6y struct_8myw6y27 = struct_8myw6y25;
						((Struct_8myw6y*)ptr48)->field_1 = struct_8myw6y27.field_1;
						if (!optional_unsigned_long_has_value.Invoke(&cpp_optional_d6hvji5))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = (Int128)(UInt128)(ulong)cpp_bit_cast_unsigned_long_unsigned_long.Invoke(optional_unsigned_long_value.Invoke(&cpp_optional_d6hvji5));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji5);
						break;
					}
					case LengthModifier_mnvaa2.t:
					{
						llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji6);
						sbyte* ptr32 = (sbyte*)(&cpp_optional_d6hvji6);
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
						Struct_8myw6y struct_8myw6y13 = Parser_internal_ArgList_get_arg_value_long.Invoke(@this, num2);
						cpp_expected* ptr34 = &cpp_optional_d6hvji6.storage;
						Struct_8myw6y struct_8myw6y14 = struct_8myw6y13;
						((Struct_8myw6y*)ptr34)->field_0 = struct_8myw6y14.field_0;
						Struct_8myw6y struct_8myw6y15 = struct_8myw6y13;
						((Struct_8myw6y*)ptr34)->field_1 = struct_8myw6y15.field_1;
						if (!optional_long_has_value.Invoke(&cpp_optional_d6hvji6))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_bit_cast_long_long.Invoke(optional_long_value.Invoke(&cpp_optional_d6hvji6));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji6);
						break;
					}
					case LengthModifier_mnvaa2.w:
					case LengthModifier_mnvaa2.wf:
						if (printf_core_LengthSpec2.bit_width == 0L)
						{
							agg_result->has_conv = 0;
						}
						else if ((ulong)printf_core_LengthSpec2.bit_width <= 32uL)
						{
							llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk9);
							sbyte* ptr21 = (sbyte*)(&cpp_optional_g66fk9);
							*(int*)ptr21 = -1431655766;
							ptr21[4] = -86;
							sbyte* ptr22 = ptr21 + 5;
							*ptr22 = -86;
							ptr22[1] = -86;
							ptr22[2] = -86;
							long storage6 = Parser_internal_ArgList_get_arg_value_int.Invoke(@this, num2);
							*(long*)(&cpp_optional_g66fk9.storage) = storage6;
							if (!optional_int_has_value.Invoke(&cpp_optional_g66fk9))
							{
								agg_result->has_conv = 0;
							}
							else
							{
								agg_result->conv_val_raw = cpp_bit_cast_int_int.Invoke(optional_int_value.Invoke(&cpp_optional_g66fk9));
							}
							llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk9);
						}
						else if ((ulong)printf_core_LengthSpec2.bit_width <= 64uL)
						{
							llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji7);
							sbyte* ptr23 = (sbyte*)(&cpp_optional_d6hvji7);
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
							Struct_8myw6y struct_8myw6y4 = Parser_internal_ArgList_get_arg_value_long.Invoke(@this, num2);
							cpp_expected* ptr25 = &cpp_optional_d6hvji7.storage;
							Struct_8myw6y struct_8myw6y5 = struct_8myw6y4;
							((Struct_8myw6y*)ptr25)->field_0 = struct_8myw6y5.field_0;
							Struct_8myw6y struct_8myw6y6 = struct_8myw6y4;
							((Struct_8myw6y*)ptr25)->field_1 = struct_8myw6y6.field_1;
							if (!optional_long_has_value.Invoke(&cpp_optional_d6hvji7))
							{
								agg_result->has_conv = 0;
							}
							else
							{
								agg_result->conv_val_raw = cpp_bit_cast_long_long.Invoke(optional_long_value.Invoke(&cpp_optional_d6hvji7));
							}
							llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji7);
						}
						else if ((ulong)printf_core_LengthSpec2.bit_width <= 64uL)
						{
							llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji8);
							sbyte* ptr26 = (sbyte*)(&cpp_optional_d6hvji8);
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
							Struct_8myw6y struct_8myw6y7 = Parser_internal_ArgList_get_arg_value_long_long.Invoke(@this, num2);
							cpp_expected* ptr28 = &cpp_optional_d6hvji8.storage;
							Struct_8myw6y struct_8myw6y8 = struct_8myw6y7;
							((Struct_8myw6y*)ptr28)->field_0 = struct_8myw6y8.field_0;
							Struct_8myw6y struct_8myw6y9 = struct_8myw6y7;
							((Struct_8myw6y*)ptr28)->field_1 = struct_8myw6y9.field_1;
							if (!optional_long_long_has_value.Invoke(&cpp_optional_d6hvji8))
							{
								agg_result->has_conv = 0;
							}
							else
							{
								agg_result->conv_val_raw = cpp_bit_cast_long_long_long_long.Invoke(optional_long_long_value.Invoke(&cpp_optional_d6hvji8));
							}
							llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji8);
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji9);
							sbyte* ptr29 = (sbyte*)(&cpp_optional_d6hvji9);
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
							Struct_8myw6y struct_8myw6y10 = Parser_internal_ArgList_get_arg_value_long.Invoke(@this, num2);
							cpp_expected* ptr31 = &cpp_optional_d6hvji9.storage;
							Struct_8myw6y struct_8myw6y11 = struct_8myw6y10;
							((Struct_8myw6y*)ptr31)->field_0 = struct_8myw6y11.field_0;
							Struct_8myw6y struct_8myw6y12 = struct_8myw6y10;
							((Struct_8myw6y*)ptr31)->field_1 = struct_8myw6y12.field_1;
							if (!optional_long_has_value.Invoke(&cpp_optional_d6hvji9))
							{
								agg_result->has_conv = 0;
							}
							else
							{
								agg_result->conv_val_raw = cpp_bit_cast_long_long.Invoke(optional_long_value.Invoke(&cpp_optional_d6hvji9));
							}
							llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji9);
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
					if (printf_core_LengthSpec2.lm != LengthModifier_mnvaa2.L)
					{
						llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_vhbvq8);
						sbyte* ptr49 = (sbyte*)(&cpp_optional_vhbvq8);
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
						Struct_8myw6y struct_8myw6y28 = Parser_internal_ArgList_get_arg_value_double.Invoke(@this, num2);
						cpp_optional_double_OptionalStorage* ptr51 = &cpp_optional_vhbvq8.storage;
						Struct_8myw6y struct_8myw6y29 = struct_8myw6y28;
						((Struct_8myw6y*)ptr51)->field_0 = struct_8myw6y29.field_0;
						Struct_8myw6y struct_8myw6y30 = struct_8myw6y28;
						((Struct_8myw6y*)ptr51)->field_1 = struct_8myw6y30.field_1;
						if (!optional_double_has_value.Invoke(&cpp_optional_vhbvq8))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = (Int128)(UInt128)(ulong)cpp_bit_cast_unsigned_long_double.Invoke(optional_double_value.Invoke(&cpp_optional_vhbvq8));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_vhbvq8);
						break;
					}
					llvm_lifetime_start_p0.Invoke(32L, &cpp_optional_59q3zq2);
					sbyte* ptr52 = (sbyte*)(&cpp_optional_59q3zq2);
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
					Parser_internal_ArgList_get_arg_value_long_double.Invoke(&cpp_optional_59q3zq2, @this, num2);
					if (!optional_long_double_has_value.Invoke(&cpp_optional_59q3zq2))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb7 = cpp_bit_cast_unsigned_int128_long_double.Invoke(optional_long_double_value.Invoke(&cpp_optional_59q3zq2));
						Int128* num9 = &conv_val_raw;
						Struct_fiz2nb struct_fiz2nb8 = struct_fiz2nb7;
						*(long*)num9 = struct_fiz2nb8.field_0;
						byte* num10 = (byte*)(&conv_val_raw) + 8u;
						Struct_fiz2nb struct_fiz2nb9 = struct_fiz2nb7;
						*(long*)num10 = struct_fiz2nb9.field_1;
						agg_result->conv_val_raw = conv_val_raw;
					}
					llvm_lifetime_end_p0.Invoke(32L, &cpp_optional_59q3zq2);
					break;
				}
				case 82:
				case 114:
				{
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk10);
					sbyte* ptr11 = (sbyte*)(&cpp_optional_g66fk10);
					*(int*)ptr11 = -1431655766;
					ptr11[4] = -86;
					sbyte* ptr12 = ptr11 + 5;
					*ptr12 = -86;
					ptr12[1] = -86;
					ptr12[2] = -86;
					long storage4 = Parser_internal_ArgList_get_arg_value_unsigned_int.Invoke(@this, num2);
					*(long*)(&cpp_optional_g66fk10.storage) = storage4;
					if (!optional_unsigned_int_has_value.Invoke(&cpp_optional_g66fk10))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->conv_val_raw = (Int128)(UInt128)(uint)cpp_bit_cast_unsigned_int_unsigned_int.Invoke(optional_unsigned_int_value.Invoke(&cpp_optional_g66fk10));
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk10);
					break;
				}
				case 75:
				case 107:
					if (printf_core_LengthSpec2.lm == LengthModifier_mnvaa2.l)
					{
						llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_d6hvji10);
						sbyte* ptr13 = (sbyte*)(&cpp_optional_d6hvji10);
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
						Struct_8myw6y struct_8myw6y = Parser_internal_ArgList_get_arg_value_unsigned_long.Invoke(@this, num2);
						cpp_expected* ptr15 = &cpp_optional_d6hvji10.storage;
						Struct_8myw6y struct_8myw6y2 = struct_8myw6y;
						((Struct_8myw6y*)ptr15)->field_0 = struct_8myw6y2.field_0;
						Struct_8myw6y struct_8myw6y3 = struct_8myw6y;
						((Struct_8myw6y*)ptr15)->field_1 = struct_8myw6y3.field_1;
						if (!optional_unsigned_long_has_value.Invoke(&cpp_optional_d6hvji10))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = (Int128)(UInt128)(ulong)cpp_bit_cast_unsigned_long_unsigned_long.Invoke(optional_unsigned_long_value.Invoke(&cpp_optional_d6hvji10));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji10);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_g66fk11);
						sbyte* ptr16 = (sbyte*)(&cpp_optional_g66fk11);
						*(int*)ptr16 = -1431655766;
						ptr16[4] = -86;
						sbyte* ptr17 = ptr16 + 5;
						*ptr17 = -86;
						ptr17[1] = -86;
						ptr17[2] = -86;
						long storage5 = Parser_internal_ArgList_get_arg_value_unsigned_int.Invoke(@this, num2);
						*(long*)(&cpp_optional_g66fk11.storage) = storage5;
						if (!optional_unsigned_int_has_value.Invoke(&cpp_optional_g66fk11))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = (Int128)(UInt128)(uint)cpp_bit_cast_unsigned_int_unsigned_int.Invoke(optional_unsigned_int_value.Invoke(&cpp_optional_g66fk11));
						}
						llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_g66fk11);
					}
					break;
				case 109:
					agg_result->conv_val_raw = Errno_ToInt32.Invoke(libc_errno.Pointer);
					break;
				case 110:
				case 112:
				{
					llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_77yu8f2);
					sbyte* ptr18 = (sbyte*)(&cpp_optional_77yu8f2);
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
					Struct_yx4nca struct_yx4nca4 = Parser_internal_ArgList_get_arg_value_void.Invoke(@this, num2);
					cpp_optional_char_OptionalStorage* ptr20 = &cpp_optional_77yu8f2.storage;
					Struct_yx4nca struct_yx4nca5 = struct_yx4nca4;
					((Struct_yx4nca*)ptr20)->field_0 = struct_yx4nca5.field_0;
					Struct_yx4nca struct_yx4nca6 = struct_yx4nca4;
					((Struct_yx4nca*)ptr20)->field_1 = struct_yx4nca6.field_1;
					if (!optional_void_has_value.Invoke(&cpp_optional_77yu8f2))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->conv_val_ptr = cpp_bit_cast_void_void.Invoke(optional_void_value.Invoke(&cpp_optional_77yu8f2));
					}
					llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_77yu8f2);
					break;
				}
				case 115:
				{
					llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_77yu8f3);
					sbyte* ptr6 = (sbyte*)(&cpp_optional_77yu8f3);
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
					Struct_yx4nca struct_yx4nca = Parser_internal_ArgList_get_arg_value_char.Invoke(@this, num2);
					cpp_optional_char_OptionalStorage* ptr8 = &cpp_optional_77yu8f3.storage;
					Struct_yx4nca struct_yx4nca2 = struct_yx4nca;
					((Struct_yx4nca*)ptr8)->field_0 = struct_yx4nca2.field_0;
					Struct_yx4nca struct_yx4nca3 = struct_yx4nca;
					((Struct_yx4nca*)ptr8)->field_1 = struct_yx4nca3.field_1;
					if (!optional_char_has_value.Invoke(&cpp_optional_77yu8f3))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->conv_val_ptr = cpp_bit_cast_char_char.Invoke(optional_char_value.Invoke(&cpp_optional_77yu8f3));
					}
					llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_77yu8f3);
					break;
				}
				default:
					agg_result->has_conv = 0;
					break;
				}
				if (((sbyte*)@this->str)[@this->cur_pos] != 0)
				{
					@this->cur_pos++;
				}
				llvm_lifetime_end_p0.Invoke(16L, &printf_core_LengthSpec2);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			else
			{
				agg_result->has_conv = 0;
				while (((sbyte*)@this->str)[@this->cur_pos] != 37 && ((sbyte*)@this->str)[@this->cur_pos] != 0)
				{
					@this->cur_pos++;
				}
			}
			llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
			string_view_Constructor.Invoke(&cpp_string_view2, (byte*)@this->str + num, @this->cur_pos - num);
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->raw_string, &cpp_string_view2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
