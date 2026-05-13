using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE16get_next_sectionEv")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::get_next_section()")]
internal static partial class printf_core_Parser_internal_ArgList_get_next_section
{
	public unsafe static void Invoke([MangledName("agg.result")] printf_core_FormatSection* agg_result, printf_core_Parser* @this)
	{
		long num = 0L;
		long num2 = 0L;
		cpp_optional_39hkks cpp_optional_39hkks2 = default(cpp_optional_39hkks);
		StrToNumResult_yrtfty strToNumResult_yrtfty = default(StrToNumResult_yrtfty);
		cpp_optional_39hkks cpp_optional_39hkks3 = default(cpp_optional_39hkks);
		StrToNumResult_yrtfty strToNumResult_yrtfty2 = default(StrToNumResult_yrtfty);
		printf_core_LengthSpec printf_core_LengthSpec2 = default(printf_core_LengthSpec);
		cpp_optional_39hkks cpp_optional_39hkks4 = default(cpp_optional_39hkks);
		cpp_optional_39hkks cpp_optional_39hkks5 = default(cpp_optional_39hkks);
		cpp_optional_d6hvji cpp_optional_d6hvji2 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji3 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji4 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji5 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji6 = default(cpp_optional_d6hvji);
		cpp_optional_39hkks cpp_optional_39hkks6 = default(cpp_optional_39hkks);
		cpp_optional_d6hvji cpp_optional_d6hvji7 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji8 = default(cpp_optional_d6hvji);
		cpp_optional_d6hvji cpp_optional_d6hvji9 = default(cpp_optional_d6hvji);
		cpp_optional_s4iqgj cpp_optional_s4iqgj2 = default(cpp_optional_s4iqgj);
		cpp_optional_59q3zq cpp_optional_59q3zq2 = default(cpp_optional_59q3zq);
		Int128 conv_val_raw = default(Int128);
		cpp_optional_39hkks cpp_optional_39hkks7 = default(cpp_optional_39hkks);
		cpp_optional_d6hvji cpp_optional_d6hvji10 = default(cpp_optional_d6hvji);
		cpp_optional_39hkks cpp_optional_39hkks8 = default(cpp_optional_39hkks);
		cpp_optional_e5s7qx cpp_optional_e5s7qx2 = default(cpp_optional_e5s7qx);
		cpp_optional_e5s7qx cpp_optional_e5s7qx3 = default(cpp_optional_e5s7qx);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		llvm_memset_p0_i64.Invoke(agg_result, -86, 80L, isVolatile: false);
		printf_core_FormatSection_FormatSection.Invoke(agg_result);
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
				num2 = printf_core_Parser_internal_ArgList_parse_index_unsigned_long.Invoke(@this, &@this->cur_pos);
				agg_result->flags = printf_core_Parser_internal_ArgList_parse_flags_unsigned_long.Invoke(@this, &@this->cur_pos);
				agg_result->min_width = 0;
				if (((sbyte*)@this->str)[@this->cur_pos] == 42)
				{
					@this->cur_pos++;
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_39hkks2);
					sbyte* ptr = (sbyte*)(&cpp_optional_39hkks2);
					*(int*)ptr = -1431655766;
					ptr[4] = -86;
					sbyte* ptr2 = ptr + 5;
					*ptr2 = -86;
					ptr2[1] = -86;
					ptr2[2] = -86;
					long storage = cpp_optional_int_printf_core_Parser_internal_ArgList_get_arg_value_int_unsigned_long.Invoke(@this, printf_core_Parser_internal_ArgList_parse_index_unsigned_long.Invoke(@this, &@this->cur_pos));
					*(long*)(&cpp_optional_39hkks2.storage) = storage;
					if (!cpp_optional_int_has_value_const.Invoke(&cpp_optional_39hkks2))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->min_width = cpp_enable_if_sizeof_int_sizeof_int_cpp_is_trivially_constructible_int_value_cpp_is_trivially_copyable_int_value_cpp_is_trivially_copyable_int_value_int_type_cpp_bit_cast_int_int_int_const.Invoke(cpp_optional_int_value.Invoke(&cpp_optional_39hkks2));
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_39hkks2);
				}
				else if (internal_isdigit_int_149.Invoke(((sbyte*)@this->str)[@this->cur_pos]))
				{
					llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_yrtfty);
					*(int*)(&strToNumResult_yrtfty) = -1431655766;
					((int*)(&strToNumResult_yrtfty))[1] = -1431655766;
					((long*)(&strToNumResult_yrtfty))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = StrToNumResult_int_internal_strtointeger_int_char_const_int_unsigned_long.Invoke((byte*)@this->str + @this->cur_pos, 10, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					StrToNumResult_yrtfty* num3 = &strToNumResult_yrtfty;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb2.field_0;
					byte* num4 = (byte*)(&strToNumResult_yrtfty) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num4 = struct_fiz2nb3.field_1;
					agg_result->min_width = strToNumResult_yrtfty.value;
					@this->cur_pos += strToNumResult_yrtfty.parsed_len;
					llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_yrtfty);
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
						llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_39hkks3);
						sbyte* ptr3 = (sbyte*)(&cpp_optional_39hkks3);
						*(int*)ptr3 = -1431655766;
						ptr3[4] = -86;
						sbyte* ptr4 = ptr3 + 5;
						*ptr4 = -86;
						ptr4[1] = -86;
						ptr4[2] = -86;
						long storage2 = cpp_optional_int_printf_core_Parser_internal_ArgList_get_arg_value_int_unsigned_long.Invoke(@this, printf_core_Parser_internal_ArgList_parse_index_unsigned_long.Invoke(@this, &@this->cur_pos));
						*(long*)(&cpp_optional_39hkks3.storage) = storage2;
						if (!cpp_optional_int_has_value_const.Invoke(&cpp_optional_39hkks3))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->precision = cpp_enable_if_sizeof_int_sizeof_int_cpp_is_trivially_constructible_int_value_cpp_is_trivially_copyable_int_value_cpp_is_trivially_copyable_int_value_int_type_cpp_bit_cast_int_int_int_const.Invoke(cpp_optional_int_value.Invoke(&cpp_optional_39hkks3));
						}
						llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_39hkks3);
					}
					else if (internal_isdigit_int_149.Invoke(((sbyte*)@this->str)[@this->cur_pos]))
					{
						llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_yrtfty2);
						*(int*)(&strToNumResult_yrtfty2) = -1431655766;
						((int*)(&strToNumResult_yrtfty2))[1] = -1431655766;
						((long*)(&strToNumResult_yrtfty2))[1] = -6148914691236517206L;
						Struct_fiz2nb struct_fiz2nb4 = StrToNumResult_int_internal_strtointeger_int_char_const_int_unsigned_long.Invoke((byte*)@this->str + @this->cur_pos, 10, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
						StrToNumResult_yrtfty* num5 = &strToNumResult_yrtfty2;
						Struct_fiz2nb struct_fiz2nb5 = struct_fiz2nb4;
						*(long*)num5 = struct_fiz2nb5.field_0;
						byte* num6 = (byte*)(&strToNumResult_yrtfty2) + 8u;
						Struct_fiz2nb struct_fiz2nb6 = struct_fiz2nb4;
						*(long*)num6 = struct_fiz2nb6.field_1;
						agg_result->precision = strToNumResult_yrtfty2.value;
						@this->cur_pos += strToNumResult_yrtfty2.parsed_len;
						llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_yrtfty2);
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
				Struct_nfiam5 struct_nfiam = printf_core_Parser_internal_ArgList_parse_length_modifier_unsigned_long.Invoke(@this, &@this->cur_pos);
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
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_39hkks4);
					sbyte* ptr9 = (sbyte*)(&cpp_optional_39hkks4);
					*(int*)ptr9 = -1431655766;
					ptr9[4] = -86;
					sbyte* ptr10 = ptr9 + 5;
					*ptr10 = -86;
					ptr10[1] = -86;
					ptr10[2] = -86;
					long storage3 = cpp_optional_int_printf_core_Parser_internal_ArgList_get_arg_value_int_unsigned_long.Invoke(@this, num2);
					*(long*)(&cpp_optional_39hkks4.storage) = storage3;
					if (!cpp_optional_int_has_value_const.Invoke(&cpp_optional_39hkks4))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->conv_val_raw = cpp_enable_if_sizeof_int_sizeof_int_cpp_is_trivially_constructible_int_value_cpp_is_trivially_copyable_int_value_cpp_is_trivially_copyable_int_value_int_type_cpp_bit_cast_int_int_int_const.Invoke(cpp_optional_int_value.Invoke(&cpp_optional_39hkks4));
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_39hkks4);
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
						llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_39hkks5);
						sbyte* ptr38 = (sbyte*)(&cpp_optional_39hkks5);
						*(int*)ptr38 = -1431655766;
						ptr38[4] = -86;
						sbyte* ptr39 = ptr38 + 5;
						*ptr39 = -86;
						ptr39[1] = -86;
						ptr39[2] = -86;
						long storage7 = cpp_optional_int_printf_core_Parser_internal_ArgList_get_arg_value_int_unsigned_long.Invoke(@this, num2);
						*(long*)(&cpp_optional_39hkks5.storage) = storage7;
						if (!cpp_optional_int_has_value_const.Invoke(&cpp_optional_39hkks5))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_enable_if_sizeof_int_sizeof_int_cpp_is_trivially_constructible_int_value_cpp_is_trivially_copyable_int_value_cpp_is_trivially_copyable_int_value_int_type_cpp_bit_cast_int_int_int_const.Invoke(cpp_optional_int_value.Invoke(&cpp_optional_39hkks5));
						}
						llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_39hkks5);
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
						Struct_8myw6y struct_8myw6y19 = cpp_optional_long_printf_core_Parser_internal_ArgList_get_arg_value_long_unsigned_long.Invoke(@this, num2);
						cpp_expected* ptr42 = &cpp_optional_d6hvji2.storage;
						Struct_8myw6y struct_8myw6y20 = struct_8myw6y19;
						((Struct_8myw6y*)ptr42)->field_0 = struct_8myw6y20.field_0;
						Struct_8myw6y struct_8myw6y21 = struct_8myw6y19;
						((Struct_8myw6y*)ptr42)->field_1 = struct_8myw6y21.field_1;
						if (!cpp_optional_long_has_value_const.Invoke(&cpp_optional_d6hvji2))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_enable_if_sizeof_long_sizeof_long_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_long_value_long_type_cpp_bit_cast_long_long_long_const.Invoke(cpp_optional_long_value.Invoke(&cpp_optional_d6hvji2));
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
						Struct_8myw6y struct_8myw6y16 = cpp_optional_long_long_printf_core_Parser_internal_ArgList_get_arg_value_long_long_unsigned_long.Invoke(@this, num2);
						cpp_expected* ptr37 = &cpp_optional_d6hvji3.storage;
						Struct_8myw6y struct_8myw6y17 = struct_8myw6y16;
						((Struct_8myw6y*)ptr37)->field_0 = struct_8myw6y17.field_0;
						Struct_8myw6y struct_8myw6y18 = struct_8myw6y16;
						((Struct_8myw6y*)ptr37)->field_1 = struct_8myw6y18.field_1;
						if (!cpp_optional_long_long_has_value_const.Invoke(&cpp_optional_d6hvji3))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_enable_if_sizeof_long_long_sizeof_long_long_cpp_is_trivially_constructible_long_long_value_cpp_is_trivially_copyable_long_long_value_cpp_is_trivially_copyable_long_long_value_long_long_type_cpp_bit_cast_long_long_long_long_long_long_const.Invoke(cpp_optional_long_long_value.Invoke(&cpp_optional_d6hvji3));
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
						Struct_8myw6y struct_8myw6y22 = cpp_optional_long_printf_core_Parser_internal_ArgList_get_arg_value_long_unsigned_long.Invoke(@this, num2);
						cpp_expected* ptr45 = &cpp_optional_d6hvji4.storage;
						Struct_8myw6y struct_8myw6y23 = struct_8myw6y22;
						((Struct_8myw6y*)ptr45)->field_0 = struct_8myw6y23.field_0;
						Struct_8myw6y struct_8myw6y24 = struct_8myw6y22;
						((Struct_8myw6y*)ptr45)->field_1 = struct_8myw6y24.field_1;
						if (!cpp_optional_long_has_value_const.Invoke(&cpp_optional_d6hvji4))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_enable_if_sizeof_long_sizeof_long_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_long_value_long_type_cpp_bit_cast_long_long_long_const.Invoke(cpp_optional_long_value.Invoke(&cpp_optional_d6hvji4));
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
						Struct_8myw6y struct_8myw6y25 = cpp_optional_unsigned_long_printf_core_Parser_internal_ArgList_get_arg_value_unsigned_long_unsigned_long.Invoke(@this, num2);
						cpp_expected* ptr48 = &cpp_optional_d6hvji5.storage;
						Struct_8myw6y struct_8myw6y26 = struct_8myw6y25;
						((Struct_8myw6y*)ptr48)->field_0 = struct_8myw6y26.field_0;
						Struct_8myw6y struct_8myw6y27 = struct_8myw6y25;
						((Struct_8myw6y*)ptr48)->field_1 = struct_8myw6y27.field_1;
						if (!cpp_optional_unsigned_long_has_value_const.Invoke(&cpp_optional_d6hvji5))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = (Int128)(UInt128)(ulong)cpp_enable_if_sizeof_unsigned_long_sizeof_unsigned_long_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_unsigned_long_type_cpp_bit_cast_unsigned_long_unsigned_long_unsigned_long_const.Invoke(cpp_optional_unsigned_long_value.Invoke(&cpp_optional_d6hvji5));
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
						Struct_8myw6y struct_8myw6y13 = cpp_optional_long_printf_core_Parser_internal_ArgList_get_arg_value_long_unsigned_long.Invoke(@this, num2);
						cpp_expected* ptr34 = &cpp_optional_d6hvji6.storage;
						Struct_8myw6y struct_8myw6y14 = struct_8myw6y13;
						((Struct_8myw6y*)ptr34)->field_0 = struct_8myw6y14.field_0;
						Struct_8myw6y struct_8myw6y15 = struct_8myw6y13;
						((Struct_8myw6y*)ptr34)->field_1 = struct_8myw6y15.field_1;
						if (!cpp_optional_long_has_value_const.Invoke(&cpp_optional_d6hvji6))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = cpp_enable_if_sizeof_long_sizeof_long_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_long_value_long_type_cpp_bit_cast_long_long_long_const.Invoke(cpp_optional_long_value.Invoke(&cpp_optional_d6hvji6));
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
							llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_39hkks6);
							sbyte* ptr21 = (sbyte*)(&cpp_optional_39hkks6);
							*(int*)ptr21 = -1431655766;
							ptr21[4] = -86;
							sbyte* ptr22 = ptr21 + 5;
							*ptr22 = -86;
							ptr22[1] = -86;
							ptr22[2] = -86;
							long storage6 = cpp_optional_int_printf_core_Parser_internal_ArgList_get_arg_value_int_unsigned_long.Invoke(@this, num2);
							*(long*)(&cpp_optional_39hkks6.storage) = storage6;
							if (!cpp_optional_int_has_value_const.Invoke(&cpp_optional_39hkks6))
							{
								agg_result->has_conv = 0;
							}
							else
							{
								agg_result->conv_val_raw = cpp_enable_if_sizeof_int_sizeof_int_cpp_is_trivially_constructible_int_value_cpp_is_trivially_copyable_int_value_cpp_is_trivially_copyable_int_value_int_type_cpp_bit_cast_int_int_int_const.Invoke(cpp_optional_int_value.Invoke(&cpp_optional_39hkks6));
							}
							llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_39hkks6);
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
							Struct_8myw6y struct_8myw6y4 = cpp_optional_long_printf_core_Parser_internal_ArgList_get_arg_value_long_unsigned_long.Invoke(@this, num2);
							cpp_expected* ptr25 = &cpp_optional_d6hvji7.storage;
							Struct_8myw6y struct_8myw6y5 = struct_8myw6y4;
							((Struct_8myw6y*)ptr25)->field_0 = struct_8myw6y5.field_0;
							Struct_8myw6y struct_8myw6y6 = struct_8myw6y4;
							((Struct_8myw6y*)ptr25)->field_1 = struct_8myw6y6.field_1;
							if (!cpp_optional_long_has_value_const.Invoke(&cpp_optional_d6hvji7))
							{
								agg_result->has_conv = 0;
							}
							else
							{
								agg_result->conv_val_raw = cpp_enable_if_sizeof_long_sizeof_long_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_long_value_long_type_cpp_bit_cast_long_long_long_const.Invoke(cpp_optional_long_value.Invoke(&cpp_optional_d6hvji7));
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
							Struct_8myw6y struct_8myw6y7 = cpp_optional_long_long_printf_core_Parser_internal_ArgList_get_arg_value_long_long_unsigned_long.Invoke(@this, num2);
							cpp_expected* ptr28 = &cpp_optional_d6hvji8.storage;
							Struct_8myw6y struct_8myw6y8 = struct_8myw6y7;
							((Struct_8myw6y*)ptr28)->field_0 = struct_8myw6y8.field_0;
							Struct_8myw6y struct_8myw6y9 = struct_8myw6y7;
							((Struct_8myw6y*)ptr28)->field_1 = struct_8myw6y9.field_1;
							if (!cpp_optional_long_long_has_value_const.Invoke(&cpp_optional_d6hvji8))
							{
								agg_result->has_conv = 0;
							}
							else
							{
								agg_result->conv_val_raw = cpp_enable_if_sizeof_long_long_sizeof_long_long_cpp_is_trivially_constructible_long_long_value_cpp_is_trivially_copyable_long_long_value_cpp_is_trivially_copyable_long_long_value_long_long_type_cpp_bit_cast_long_long_long_long_long_long_const.Invoke(cpp_optional_long_long_value.Invoke(&cpp_optional_d6hvji8));
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
							Struct_8myw6y struct_8myw6y10 = cpp_optional_long_printf_core_Parser_internal_ArgList_get_arg_value_long_unsigned_long.Invoke(@this, num2);
							cpp_expected* ptr31 = &cpp_optional_d6hvji9.storage;
							Struct_8myw6y struct_8myw6y11 = struct_8myw6y10;
							((Struct_8myw6y*)ptr31)->field_0 = struct_8myw6y11.field_0;
							Struct_8myw6y struct_8myw6y12 = struct_8myw6y10;
							((Struct_8myw6y*)ptr31)->field_1 = struct_8myw6y12.field_1;
							if (!cpp_optional_long_has_value_const.Invoke(&cpp_optional_d6hvji9))
							{
								agg_result->has_conv = 0;
							}
							else
							{
								agg_result->conv_val_raw = cpp_enable_if_sizeof_long_sizeof_long_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_long_value_long_type_cpp_bit_cast_long_long_long_const.Invoke(cpp_optional_long_value.Invoke(&cpp_optional_d6hvji9));
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
						llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_s4iqgj2);
						sbyte* ptr49 = (sbyte*)(&cpp_optional_s4iqgj2);
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
						Struct_8myw6y struct_8myw6y28 = cpp_optional_double_printf_core_Parser_internal_ArgList_get_arg_value_double_unsigned_long.Invoke(@this, num2);
						cpp_optional_double_OptionalStorage* ptr51 = &cpp_optional_s4iqgj2.storage;
						Struct_8myw6y struct_8myw6y29 = struct_8myw6y28;
						((Struct_8myw6y*)ptr51)->field_0 = struct_8myw6y29.field_0;
						Struct_8myw6y struct_8myw6y30 = struct_8myw6y28;
						((Struct_8myw6y*)ptr51)->field_1 = struct_8myw6y30.field_1;
						if (!cpp_optional_double_has_value_const.Invoke(&cpp_optional_s4iqgj2))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = (Int128)(UInt128)(ulong)cpp_enable_if_sizeof_unsigned_long_sizeof_double_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_double_value_unsigned_long_type_cpp_bit_cast_unsigned_long_double_double_const.Invoke(cpp_optional_double_value.Invoke(&cpp_optional_s4iqgj2));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_s4iqgj2);
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
					cpp_optional_long_double_printf_core_Parser_internal_ArgList_get_arg_value_long_double_unsigned_long.Invoke(&cpp_optional_59q3zq2, @this, num2);
					if (!cpp_optional_long_double_has_value_const.Invoke(&cpp_optional_59q3zq2))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						Struct_fiz2nb struct_fiz2nb7 = cpp_enable_if_sizeof_unsigned_int128_sizeof_long_double_cpp_is_trivially_constructible_unsigned_int128_value_cpp_is_trivially_copyable_unsigned_int128_value_cpp_is_trivially_copyable_long_double_value_unsigned_int128_type_cpp_bit_cast_unsigned_int128_long_double_long_double_const.Invoke(cpp_optional_long_double_value.Invoke(&cpp_optional_59q3zq2));
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
					llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_39hkks7);
					sbyte* ptr11 = (sbyte*)(&cpp_optional_39hkks7);
					*(int*)ptr11 = -1431655766;
					ptr11[4] = -86;
					sbyte* ptr12 = ptr11 + 5;
					*ptr12 = -86;
					ptr12[1] = -86;
					ptr12[2] = -86;
					long storage4 = cpp_optional_unsigned_int_printf_core_Parser_internal_ArgList_get_arg_value_unsigned_int_unsigned_long.Invoke(@this, num2);
					*(long*)(&cpp_optional_39hkks7.storage) = storage4;
					if (!cpp_optional_unsigned_int_has_value_const.Invoke(&cpp_optional_39hkks7))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->conv_val_raw = (Int128)(UInt128)(uint)cpp_enable_if_sizeof_unsigned_int_sizeof_unsigned_int_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_unsigned_int_type_cpp_bit_cast_unsigned_int_unsigned_int_unsigned_int_const.Invoke(cpp_optional_unsigned_int_value.Invoke(&cpp_optional_39hkks7));
					}
					llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_39hkks7);
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
						Struct_8myw6y struct_8myw6y = cpp_optional_unsigned_long_printf_core_Parser_internal_ArgList_get_arg_value_unsigned_long_unsigned_long.Invoke(@this, num2);
						cpp_expected* ptr15 = &cpp_optional_d6hvji10.storage;
						Struct_8myw6y struct_8myw6y2 = struct_8myw6y;
						((Struct_8myw6y*)ptr15)->field_0 = struct_8myw6y2.field_0;
						Struct_8myw6y struct_8myw6y3 = struct_8myw6y;
						((Struct_8myw6y*)ptr15)->field_1 = struct_8myw6y3.field_1;
						if (!cpp_optional_unsigned_long_has_value_const.Invoke(&cpp_optional_d6hvji10))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = (Int128)(UInt128)(ulong)cpp_enable_if_sizeof_unsigned_long_sizeof_unsigned_long_cpp_is_trivially_constructible_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_cpp_is_trivially_copyable_unsigned_long_value_unsigned_long_type_cpp_bit_cast_unsigned_long_unsigned_long_unsigned_long_const.Invoke(cpp_optional_unsigned_long_value.Invoke(&cpp_optional_d6hvji10));
						}
						llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_d6hvji10);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &cpp_optional_39hkks8);
						sbyte* ptr16 = (sbyte*)(&cpp_optional_39hkks8);
						*(int*)ptr16 = -1431655766;
						ptr16[4] = -86;
						sbyte* ptr17 = ptr16 + 5;
						*ptr17 = -86;
						ptr17[1] = -86;
						ptr17[2] = -86;
						long storage5 = cpp_optional_unsigned_int_printf_core_Parser_internal_ArgList_get_arg_value_unsigned_int_unsigned_long.Invoke(@this, num2);
						*(long*)(&cpp_optional_39hkks8.storage) = storage5;
						if (!cpp_optional_unsigned_int_has_value_const.Invoke(&cpp_optional_39hkks8))
						{
							agg_result->has_conv = 0;
						}
						else
						{
							agg_result->conv_val_raw = (Int128)(UInt128)(uint)cpp_enable_if_sizeof_unsigned_int_sizeof_unsigned_int_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_unsigned_int_type_cpp_bit_cast_unsigned_int_unsigned_int_unsigned_int_const.Invoke(cpp_optional_unsigned_int_value.Invoke(&cpp_optional_39hkks8));
						}
						llvm_lifetime_end_p0.Invoke(8L, &cpp_optional_39hkks8);
					}
					break;
				case 109:
					agg_result->conv_val_raw = Errno_operator_int_exthys.Invoke(libc_errno.Pointer);
					break;
				case 110:
				case 112:
				{
					llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_e5s7qx2);
					sbyte* ptr18 = (sbyte*)(&cpp_optional_e5s7qx2);
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
					Struct_yx4nca struct_yx4nca4 = cpp_optional_void_printf_core_Parser_internal_ArgList_get_arg_value_void_unsigned_long.Invoke(@this, num2);
					cpp_optional_char_OptionalStorage* ptr20 = &cpp_optional_e5s7qx2.storage;
					Struct_yx4nca struct_yx4nca5 = struct_yx4nca4;
					((Struct_yx4nca*)ptr20)->field_0 = struct_yx4nca5.field_0;
					Struct_yx4nca struct_yx4nca6 = struct_yx4nca4;
					((Struct_yx4nca*)ptr20)->field_1 = struct_yx4nca6.field_1;
					if (!cpp_optional_void_has_value_const.Invoke(&cpp_optional_e5s7qx2))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->conv_val_ptr = cpp_enable_if_sizeof_void_sizeof_void_cpp_is_trivially_constructible_void_value_cpp_is_trivially_copyable_void_value_cpp_is_trivially_copyable_void_value_void_type_cpp_bit_cast_void_void_void_const.Invoke(cpp_optional_void_value.Invoke(&cpp_optional_e5s7qx2));
					}
					llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_e5s7qx2);
					break;
				}
				case 115:
				{
					llvm_lifetime_start_p0.Invoke(16L, &cpp_optional_e5s7qx3);
					sbyte* ptr6 = (sbyte*)(&cpp_optional_e5s7qx3);
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
					Struct_yx4nca struct_yx4nca = cpp_optional_char_printf_core_Parser_internal_ArgList_get_arg_value_char_unsigned_long.Invoke(@this, num2);
					cpp_optional_char_OptionalStorage* ptr8 = &cpp_optional_e5s7qx3.storage;
					Struct_yx4nca struct_yx4nca2 = struct_yx4nca;
					((Struct_yx4nca*)ptr8)->field_0 = struct_yx4nca2.field_0;
					Struct_yx4nca struct_yx4nca3 = struct_yx4nca;
					((Struct_yx4nca*)ptr8)->field_1 = struct_yx4nca3.field_1;
					if (!cpp_optional_char_has_value_const.Invoke(&cpp_optional_e5s7qx3))
					{
						agg_result->has_conv = 0;
					}
					else
					{
						agg_result->conv_val_ptr = cpp_enable_if_sizeof_char_sizeof_char_cpp_is_trivially_constructible_char_value_cpp_is_trivially_copyable_char_value_cpp_is_trivially_copyable_char_value_char_type_cpp_bit_cast_char_char_char_const.Invoke(cpp_optional_char_value.Invoke(&cpp_optional_e5s7qx3));
					}
					llvm_lifetime_end_p0.Invoke(16L, &cpp_optional_e5s7qx3);
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
			cpp_string_view_string_view_char_const_unsigned_long.Invoke(&cpp_string_view2, (byte*)@this->str + num, @this->cur_pos - num);
			llvm_memcpy_p0_p0_i64.Invoke(&agg_result->raw_string, &cpp_string_view2, 16L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
