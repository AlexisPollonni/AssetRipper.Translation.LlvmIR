using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_parse_length_modifier
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE21parse_length_modifierEPm")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_length_modifier(unsigned long*)")]
	public unsafe static LengthModifier_3739tr Invoke([MangledName("this")] Scanf_core_Parser* This, [MangledName("local_pos")][NativeType("unsigned long*")] void* Local_pos)
	{
		unchecked
		{
			switch (((sbyte*)This->Str)[*(long*)Local_pos])
			{
			case 108:
				if (((sbyte*)This->Str)[*(long*)Local_pos + 1L] == 108)
				{
					*(long*)Local_pos += 2L;
					return LengthModifier_3739tr.ll;
				}
				(*(long*)Local_pos)++;
				return LengthModifier_3739tr.l;
			case 104:
				if (((sbyte*)This->Str)[*(long*)Local_pos + 1L] == 104)
				{
					*(long*)Local_pos += 2L;
					return LengthModifier_3739tr.hh;
				}
				(*(long*)Local_pos)++;
				return LengthModifier_3739tr.h;
			case 76:
				(*(long*)Local_pos)++;
				return LengthModifier_3739tr.L;
			case 106:
				(*(long*)Local_pos)++;
				return LengthModifier_3739tr.j;
			case 122:
				(*(long*)Local_pos)++;
				return LengthModifier_3739tr.z;
			case 116:
				(*(long*)Local_pos)++;
				return LengthModifier_3739tr.t;
			default:
				return LengthModifier_3739tr.NONE;
			}
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE21parse_length_modifierEPm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_length_modifier(unsigned long*)")]
	public unsafe static Struct_nfiam5 Invoke([MangledName("this")] Printf_core_Parser* This, [MangledName("local_pos")][NativeType("unsigned long*")] void* Local_pos)
	{
		Printf_core_LengthSpec printf_core_LengthSpec = default(Printf_core_LengthSpec);
		int lm = 0;
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		int num = 0;
		unchecked
		{
			switch (((sbyte*)This->Str)[*(long*)Local_pos])
			{
			case 108:
				if (((sbyte*)This->Str)[*(long*)Local_pos + 1L] == 108)
				{
					*(long*)Local_pos += 2L;
					printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.ll;
					printf_core_LengthSpec.Bit_width = 0L;
				}
				else
				{
					(*(long*)Local_pos)++;
					printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.l;
					printf_core_LengthSpec.Bit_width = 0L;
				}
				break;
			case 119:
				Llvm_lifetime_start_p0.Invoke(4L, &lm);
				lm = -1431655766;
				if (((sbyte*)This->Str)[*(long*)Local_pos + 1L] == 102)
				{
					*(long*)Local_pos += 2L;
					lm = 9;
				}
				else
				{
					(*(long*)Local_pos)++;
					lm = 8;
				}
				if (Internal_isdigit_prmaet.Invoke(((sbyte*)This->Str)[*(long*)Local_pos]))
				{
					Llvm_lifetime_start_p0.Invoke(16L, &strToNumResult_imtnam);
					*(int*)(&strToNumResult_imtnam) = -1431655766;
					((int*)(&strToNumResult_imtnam))[1] = -1431655766;
					((long*)(&strToNumResult_imtnam))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)This->Str + *(long*)Local_pos, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					StrToNumResult_imtnam* num2 = &strToNumResult_imtnam;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num2 = struct_fiz2nb2.field_0;
					byte* num3 = (byte*)(&strToNumResult_imtnam) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb3.field_1;
					*(long*)Local_pos += strToNumResult_imtnam.Parsed_len;
					printf_core_LengthSpec.Lm = (LengthModifier_mnvaa2)lm;
					Llvm_lifetime_start_p0.Invoke(4L, &num);
					num = 0;
					printf_core_LengthSpec.Bit_width = *(int*)Cpp_max_int.Invoke(&num, &strToNumResult_imtnam.Value);
					Llvm_lifetime_end_p0.Invoke(4L, &num);
					Llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
				}
				else
				{
					printf_core_LengthSpec.Lm = (LengthModifier_mnvaa2)lm;
					printf_core_LengthSpec.Bit_width = 0L;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &lm);
				break;
			case 104:
				if (((sbyte*)This->Str)[*(long*)Local_pos + 1L] == 104)
				{
					*(long*)Local_pos += 2L;
					printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.hh;
					printf_core_LengthSpec.Bit_width = 0L;
				}
				else
				{
					(*(long*)Local_pos)++;
					printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.h;
					printf_core_LengthSpec.Bit_width = 0L;
				}
				break;
			case 76:
				(*(long*)Local_pos)++;
				printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.L;
				printf_core_LengthSpec.Bit_width = 0L;
				break;
			case 106:
				(*(long*)Local_pos)++;
				printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.j;
				printf_core_LengthSpec.Bit_width = 0L;
				break;
			case 122:
				(*(long*)Local_pos)++;
				printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.z;
				printf_core_LengthSpec.Bit_width = 0L;
				break;
			case 116:
				(*(long*)Local_pos)++;
				printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.t;
				printf_core_LengthSpec.Bit_width = 0L;
				break;
			default:
				printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.none;
				printf_core_LengthSpec.Bit_width = 0L;
				break;
			}
			return *(Struct_nfiam5*)(&printf_core_LengthSpec);
		}
	}
}
