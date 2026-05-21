using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_parse_index_uewqxq
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core6ParserINS_8internal7ArgListEE11parse_indexEPm")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_index(unsigned long*)")]
	[CleanName("Parser_internal_ArgList_parse_index")]
	public unsafe static long Invoke([MangledName("this")] Llvm_libc_20_1_2_scanf_core_Parser* This, [MangledName("local_pos")][NativeType("unsigned long*")] void* Local_pos)
	{
		Llvm_libc_20_1_2_StrToNumResult_imtnam llvm_libc_20_1_2_StrToNumResult_imtnam = default(Llvm_libc_20_1_2_StrToNumResult_imtnam);
		long num = 0L;
		unchecked
		{
			long result;
			if (Internal_isdigit_gvvitd.Invoke(((sbyte*)This->Str)[*(long*)Local_pos]))
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
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = llvm_libc_20_1_2_StrToNumResult_imtnam.Value;
				if (((sbyte*)This->Str)[*(long*)Local_pos + llvm_libc_20_1_2_StrToNumResult_imtnam.Parsed_len] != 36)
				{
					result = 0L;
				}
				else
				{
					*(long*)Local_pos = checked(1L + llvm_libc_20_1_2_StrToNumResult_imtnam.Parsed_len) + *(long*)Local_pos;
					result = num;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num);
				Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_StrToNumResult_imtnam);
			}
			else
			{
				result = 0L;
			}
			return result;
		}
	}
}
