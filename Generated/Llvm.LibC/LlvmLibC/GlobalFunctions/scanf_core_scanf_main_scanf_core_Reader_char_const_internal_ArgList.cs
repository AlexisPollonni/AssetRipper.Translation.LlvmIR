using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core10scanf_mainEPNS0_6ReaderEPKcRNS_8internal7ArgListE")]
[DemangledName("__llvm_libc_20_1_2_::scanf_core::scanf_main(__llvm_libc_20_1_2_::scanf_core::Reader*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
internal static partial class scanf_core_scanf_main_scanf_core_Reader_char_const_internal_ArgList
{
	public unsafe static int Invoke(void* reader, void* str, void* args)
	{
		scanf_core_Parser scanf_core_Parser2 = default(scanf_core_Parser);
		int num = 0;
		int num2 = 0;
		scanf_core_FormatSection scanf_core_FormatSection2 = default(scanf_core_FormatSection);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		scanf_core_FormatSection scanf_core_FormatSection3 = default(scanf_core_FormatSection);
		llvm_lifetime_start_p0.Invoke(72L, &scanf_core_Parser2);
		llvm_memset_p0_i64.Invoke(&scanf_core_Parser2, -86, 72L, isVolatile: false);
		scanf_core_Parser_internal_ArgList_Parser_char_const_internal_ArgList.Invoke(&scanf_core_Parser2, str, args);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		llvm_lifetime_start_p0.Invoke(88L, &scanf_core_FormatSection2);
		llvm_memset_p0_i64.Invoke(&scanf_core_FormatSection2, -86, 88L, isVolatile: false);
		scanf_core_Parser_internal_ArgList_get_next_section.Invoke(&scanf_core_FormatSection2, &scanf_core_Parser2);
		while (!cpp_string_view_empty_const.Invoke(&scanf_core_FormatSection2.raw_string) && num == 0)
		{
			if ((scanf_core_FormatSection2.has_conv & 1) == 1)
			{
				num = scanf_core_convert_scanf_core_Reader_scanf_core_FormatSection_const.Invoke(reader, &scanf_core_FormatSection2);
				if (scanf_core_FormatSection2.conv_name != 110)
				{
					int num3 = InstructionHelper.Select(num == 0, 1, 0);
					num2 += num3;
				}
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &scanf_core_FormatSection2.raw_string, 16L, isVolatile: false);
				num = unchecked(scanf_core_raw_match_scanf_core_Reader_cpp_string_view.Invoke(reader, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]));
			}
			llvm_lifetime_start_p0.Invoke(88L, &scanf_core_FormatSection3);
			scanf_core_Parser_internal_ArgList_get_next_section.Invoke(&scanf_core_FormatSection3, &scanf_core_Parser2);
			llvm_memcpy_p0_p0_i64.Invoke(&scanf_core_FormatSection2, &scanf_core_FormatSection3, 88L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(88L, &scanf_core_FormatSection3);
		}
		llvm_lifetime_end_p0.Invoke(88L, &scanf_core_FormatSection2);
		int result = num2;
		llvm_lifetime_end_p0.Invoke(4L, &num2);
		llvm_lifetime_end_p0.Invoke(4L, &num);
		scanf_core_Parser_internal_ArgList_Parser.Invoke(&scanf_core_Parser2);
		llvm_lifetime_end_p0.Invoke(72L, &scanf_core_Parser2);
		return result;
	}
}
