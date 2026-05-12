using LlvmLibC.Enumerations;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE21parse_length_modifierEPm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_length_modifier(unsigned long*)")]
internal static partial class printf_core_Parser_internal_ArgList_parse_length_modifier_unsigned_long
{
	public unsafe static Struct_nfiam5 Invoke(printf_core_Parser* @this, void* local_pos)
	{
		printf_core_LengthSpec printf_core_LengthSpec2 = default(printf_core_LengthSpec);
		int lm = 0;
		StrToNumResult_yrtfty strToNumResult_yrtfty = default(StrToNumResult_yrtfty);
		int num = 0;
		unchecked
		{
			switch (((sbyte*)@this->str)[*(long*)local_pos])
			{
			case 108:
				if (((sbyte*)@this->str)[*(long*)local_pos + 1L] == 108)
				{
					*(long*)local_pos += 2L;
					printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.ll;
					printf_core_LengthSpec2.bit_width = 0L;
				}
				else
				{
					(*(long*)local_pos)++;
					printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.l;
					printf_core_LengthSpec2.bit_width = 0L;
				}
				break;
			case 119:
				llvm_lifetime_start_p0.Invoke(4L, &lm);
				lm = -1431655766;
				if (((sbyte*)@this->str)[*(long*)local_pos + 1L] == 102)
				{
					*(long*)local_pos += 2L;
					lm = 9;
				}
				else
				{
					(*(long*)local_pos)++;
					lm = 8;
				}
				if (internal_isdigit_int_149.Invoke(((sbyte*)@this->str)[*(long*)local_pos]))
				{
					llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_yrtfty);
					*(int*)(&strToNumResult_yrtfty) = -1431655766;
					((int*)(&strToNumResult_yrtfty))[1] = -1431655766;
					((long*)(&strToNumResult_yrtfty))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = StrToNumResult_int_internal_strtointeger_int_char_const_int_unsigned_long.Invoke((byte*)@this->str + *(long*)local_pos, 10, cpp_internal_integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					StrToNumResult_yrtfty* num2 = &strToNumResult_yrtfty;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num2 = struct_fiz2nb2.field_0;
					byte* num3 = (byte*)(&strToNumResult_yrtfty) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb3.field_1;
					*(long*)local_pos += strToNumResult_yrtfty.parsed_len;
					printf_core_LengthSpec2.lm = (LengthModifier_mnvaa2)lm;
					llvm_lifetime_start_p0.Invoke(4L, &num);
					num = 0;
					printf_core_LengthSpec2.bit_width = *(int*)int_const_cpp_max_int_int_const_int_const.Invoke(&num, &strToNumResult_yrtfty.value);
					llvm_lifetime_end_p0.Invoke(4L, &num);
					llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_yrtfty);
				}
				else
				{
					printf_core_LengthSpec2.lm = (LengthModifier_mnvaa2)lm;
					printf_core_LengthSpec2.bit_width = 0L;
				}
				llvm_lifetime_end_p0.Invoke(4L, &lm);
				break;
			case 104:
				if (((sbyte*)@this->str)[*(long*)local_pos + 1L] == 104)
				{
					*(long*)local_pos += 2L;
					printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.hh;
					printf_core_LengthSpec2.bit_width = 0L;
				}
				else
				{
					(*(long*)local_pos)++;
					printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.h;
					printf_core_LengthSpec2.bit_width = 0L;
				}
				break;
			case 76:
				(*(long*)local_pos)++;
				printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.L;
				printf_core_LengthSpec2.bit_width = 0L;
				break;
			case 106:
				(*(long*)local_pos)++;
				printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.j;
				printf_core_LengthSpec2.bit_width = 0L;
				break;
			case 122:
				(*(long*)local_pos)++;
				printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.z;
				printf_core_LengthSpec2.bit_width = 0L;
				break;
			case 116:
				(*(long*)local_pos)++;
				printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.t;
				printf_core_LengthSpec2.bit_width = 0L;
				break;
			default:
				printf_core_LengthSpec2.lm = LengthModifier_mnvaa2.none;
				printf_core_LengthSpec2.bit_width = 0L;
				break;
			}
			return *(Struct_nfiam5*)(&printf_core_LengthSpec2);
		}
	}
}
