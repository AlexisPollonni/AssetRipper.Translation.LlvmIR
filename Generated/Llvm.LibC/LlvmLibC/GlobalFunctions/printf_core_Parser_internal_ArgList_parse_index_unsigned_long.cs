using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core6ParserINS_8internal7ArgListEE11parse_indexEPm")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Parser<__llvm_libc_20_1_2_::internal::ArgList>::parse_index(unsigned long*)")]
internal static partial class printf_core_Parser_internal_ArgList_parse_index_unsigned_long
{
	public unsafe static long Invoke(printf_core_Parser* @this, void* local_pos)
	{
		StrToNumResult_yrtfty strToNumResult_yrtfty = default(StrToNumResult_yrtfty);
		long num = 0L;
		unchecked
		{
			long result;
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
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = strToNumResult_yrtfty.value;
				if (((sbyte*)@this->str)[*(long*)local_pos + strToNumResult_yrtfty.parsed_len] != 36)
				{
					result = 0L;
				}
				else
				{
					*(long*)local_pos = checked(1L + strToNumResult_yrtfty.parsed_len) + *(long*)local_pos;
					result = num;
				}
				llvm_lifetime_end_p0.Invoke(8L, &num);
				llvm_lifetime_end_p0.Invoke(16L, &strToNumResult_yrtfty);
			}
			else
			{
				result = 0L;
			}
			return result;
		}
	}
}
