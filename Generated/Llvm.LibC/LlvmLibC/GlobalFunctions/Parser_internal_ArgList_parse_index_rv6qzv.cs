using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Parser_internal_ArgList_parse_index_rv6qzv
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE11parse_indexEPm")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_index(unsigned long*)")]
	[CleanName("Parser_internal_ArgList_parse_index")]
	public unsafe static long Invoke([MangledName("this")] Printf_core_Parser* This, [MangledName("local_pos")][NativeType("unsigned long*")] void* Local_pos)
	{
		StrToNumResult_imtnam strToNumResult_imtnam = default(StrToNumResult_imtnam);
		long num = 0L;
		unchecked
		{
			long result;
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
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = strToNumResult_imtnam.Value;
				if (((sbyte*)This->Str)[*(long*)Local_pos + strToNumResult_imtnam.Parsed_len] != 36)
				{
					result = 0L;
				}
				else
				{
					*(long*)Local_pos = checked(1L + strToNumResult_imtnam.Parsed_len) + *(long*)Local_pos;
					result = num;
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num);
				Llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_imtnam);
			}
			else
			{
				result = 0L;
			}
			return result;
		}
	}
}
