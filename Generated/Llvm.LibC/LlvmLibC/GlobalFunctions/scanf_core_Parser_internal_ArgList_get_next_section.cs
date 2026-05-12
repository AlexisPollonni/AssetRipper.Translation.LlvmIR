using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE16get_next_sectionEv")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_section()")]
internal static partial class scanf_core_Parser_internal_ArgList_get_next_section
{
	public unsafe static void Invoke([MangledName("agg.result")] scanf_core_FormatSection* agg_result, scanf_core_Parser* @this)
	{
		long num = 0L;
		long num2 = 0L;
		StrToNumResult_yrtfty strToNumResult_yrtfty = default(StrToNumResult_yrtfty);
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
		scanf_core_FormatSection_FormatSection.Invoke(agg_result);
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
				num2 = scanf_core_Parser_internal_ArgList_parse_index_unsigned_long.Invoke(@this, &@this->cur_pos);
				if (((sbyte*)@this->str)[@this->cur_pos] == 42)
				{
					@this->cur_pos++;
					agg_result->flags = FormatFlags_96pze4.NO_WRITE;
				}
				agg_result->max_width = -1;
				if (internal_isdigit_int_137.Invoke(((sbyte*)@this->str)[@this->cur_pos]))
				{
					llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_yrtfty);
					*(int*)(&strToNumResult_yrtfty) = -1431655766;
					((int*)(&strToNumResult_yrtfty))[1] = -1431655766;
					((long*)(&strToNumResult_yrtfty))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = StrToNumResult_int_internal_strtointeger_int_char_const_int_unsigned_long.Invoke((byte*)@this->str + @this->cur_pos, 10, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					StrToNumResult_yrtfty* num5 = &strToNumResult_yrtfty;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num5 = struct_fiz2nb2.field_0;
					byte* num6 = (byte*)(&strToNumResult_yrtfty) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num6 = struct_fiz2nb3.field_1;
					agg_result->max_width = strToNumResult_yrtfty.value;
					@this->cur_pos += strToNumResult_yrtfty.parsed_len;
					llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_yrtfty);
				}
				llvm_lifetime_start_p0.Invoke(4L, &num3);
				num3 = (int)(agg_result->length_modifier = scanf_core_Parser_internal_ArgList_parse_length_modifier_unsigned_long.Invoke(@this, &@this->cur_pos));
				agg_result->conv_name = ((sbyte*)@this->str)[@this->cur_pos];
				if (((byte)agg_result->flags & 1) == 0)
				{
					agg_result->output_ptr = void_scanf_core_Parser_internal_ArgList_get_arg_value_void_unsigned_long.Invoke(@this, num2);
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
					cpp_bitset_256ul_bitset.Invoke(&cpp_array_jgy3xh2);
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
						cpp_bitset_256ul_set_unsigned_long.Invoke(&cpp_array_jgy3xh2, 93L);
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
							cpp_bitset_256ul_set_range_unsigned_long_unsigned_long.Invoke(&cpp_array_jgy3xh2, b7, b8);
							@this->cur_pos += 2L;
							llvm_lifetime_end_p0.Invoke(1L, &b8);
							llvm_lifetime_end_p0.Invoke(1L, &b7);
							llvm_lifetime_end_p0.Invoke(1L, &b6);
							llvm_lifetime_end_p0.Invoke(1L, &b5);
						}
						else
						{
							cpp_bitset_256ul_set_unsigned_long.Invoke(&cpp_array_jgy3xh2, ((sbyte*)@this->str)[@this->cur_pos]);
							@this->cur_pos++;
						}
					}
					if ((b4 & 1) == 1)
					{
						cpp_bitset_256ul_flip.Invoke(&cpp_array_jgy3xh2);
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
			cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, (byte*)@this->str + num, @this->cur_pos - num);
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->raw_string, &cpp_string_view2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
