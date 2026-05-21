using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_parse_length_modifier
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE21parse_length_modifierEPm")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_length_modifier(unsigned long*)")]
	public unsafe static LengthModifier_3739tr Invoke([MangledName("this")] Llvm_libc_20_1_2_scanf_core_Parser* This, [MangledName("local_pos")][NativeType("unsigned long*")] void* Local_pos)
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
	public unsafe static Struct_nfiam5 Invoke([MangledName("this")] Llvm_libc_20_1_2_printf_core_Parser* This, [MangledName("local_pos")][NativeType("unsigned long*")] void* Local_pos)
	{
		Llvm_libc_20_1_2_printf_core_LengthSpec llvm_libc_20_1_2_printf_core_LengthSpec = default(Llvm_libc_20_1_2_printf_core_LengthSpec);
		int lm = 0;
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		int num = 0;
		unchecked
		{
			switch (((sbyte*)This->Str)[*(long*)Local_pos])
			{
			case 108:
				if (((sbyte*)This->Str)[*(long*)Local_pos + 1L] == 108)
				{
					*(long*)Local_pos += 2L;
					llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.ll;
					llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				}
				else
				{
					(*(long*)Local_pos)++;
					llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.l;
					llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
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
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
					*(int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) = -1431655766;
					((int*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -1431655766;
					((long*)(&llvm_libc_20_1_2_StrToNumResult_imtnam))[1] = -6148914691236517206L;
					Struct_fiz2nb struct_fiz2nb = Internal_strtointeger_int.Invoke((byte*)This->Str + *(long*)Local_pos, 10, Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke());
					Llvm_libc_20_1_2_StrToNumResult_imtnam* num2 = &llvm_libc_20_1_2_StrToNumResult_imtnam;
					Struct_fiz2nb struct_fiz2nb2 = struct_fiz2nb;
					*(long*)num2 = struct_fiz2nb2.field_0;
					byte* num3 = (byte*)(&llvm_libc_20_1_2_StrToNumResult_imtnam) + 8u;
					Struct_fiz2nb struct_fiz2nb3 = struct_fiz2nb;
					*(long*)num3 = struct_fiz2nb3.field_1;
					*(long*)Local_pos += llvm_libc_20_1_2_StrToNumResult_imtnam.Parsed_len;
					llvm_libc_20_1_2_printf_core_LengthSpec.Lm = (LengthModifier_mnvaa2)lm;
					Llvm_lifetime_start_p0.Invoke(4L, &num);
					num = 0;
					llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = *(int*)Cpp_max_int.Invoke(&num, &llvm_libc_20_1_2_StrToNumResult_imtnam.Value);
					Llvm_lifetime_end_p0.Invoke(4L, &num);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
				}
				else
				{
					llvm_libc_20_1_2_printf_core_LengthSpec.Lm = (LengthModifier_mnvaa2)lm;
					llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				}
				Llvm_lifetime_end_p0.Invoke(4L, &lm);
				break;
			case 104:
				if (((sbyte*)This->Str)[*(long*)Local_pos + 1L] == 104)
				{
					*(long*)Local_pos += 2L;
					llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.hh;
					llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				}
				else
				{
					(*(long*)Local_pos)++;
					llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.h;
					llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				}
				break;
			case 76:
				(*(long*)Local_pos)++;
				llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.L;
				llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				break;
			case 106:
				(*(long*)Local_pos)++;
				llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.j;
				llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				break;
			case 122:
				(*(long*)Local_pos)++;
				llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.z;
				llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				break;
			case 116:
				(*(long*)Local_pos)++;
				llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.t;
				llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				break;
			default:
				llvm_libc_20_1_2_printf_core_LengthSpec.Lm = LengthModifier_mnvaa2.none;
				llvm_libc_20_1_2_printf_core_LengthSpec.Bit_width = 0L;
				break;
			}
			return *(Struct_nfiam5*)(&llvm_libc_20_1_2_printf_core_LengthSpec);
		}
	}
}
