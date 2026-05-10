using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11printf_mainEPNS0_6WriterEPKcRNS_8internal7ArgListE")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::printf_main(__llvm_libc_20_1_2_::printf_core::Writer*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
internal static partial class printf_core_printf_main_printf_core_Writer_char_const_internal_ArgList
{
	public unsafe static int Invoke(void* writer, void* str, void* args)
	{
		int result = 0;
		printf_core_Parser printf_core_Parser2 = default(printf_core_Parser);
		int num = 0;
		printf_core_FormatSection printf_core_FormatSection2 = default(printf_core_FormatSection);
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		printf_core_FormatSection printf_core_FormatSection3 = default(printf_core_FormatSection);
		llvm_lifetime_start_p0.Invoke(328L, &printf_core_Parser2);
		llvm_memset_p0_i64.Invoke(&printf_core_Parser2, -86, 328L, isVolatile: false);
		printf_core_Parser_internal_ArgList_Parser_char_const_internal_ArgList.Invoke(&printf_core_Parser2, str, args);
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection2);
		llvm_memset_p0_i64.Invoke(&printf_core_FormatSection2, -86, 80L, isVolatile: false);
		printf_core_Parser_internal_ArgList_get_next_section.Invoke(&printf_core_FormatSection2, &printf_core_Parser2);
		int num2;
		while (true)
		{
			if (((cpp_string_view_empty_const.Invoke(&printf_core_FormatSection2.raw_string) ? 1u : 0u) ^ 0xFFFFFFFFu) == 0)
			{
				num2 = 2;
				break;
			}
			if ((printf_core_FormatSection2.has_conv & 1) == 1)
			{
				num = printf_core_convert_printf_core_Writer_printf_core_FormatSection_const.Invoke(writer, &printf_core_FormatSection2);
			}
			else
			{
				llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view2, &printf_core_FormatSection2.raw_string, 16L, isVolatile: false);
				num = unchecked(printf_core_Writer_write_cpp_string_view.Invoke(writer, *(void**)(&cpp_string_view2), ((long*)(&cpp_string_view2))[1]));
			}
			if (num < 0)
			{
				result = num;
				num2 = 1;
				break;
			}
			llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection3);
			printf_core_Parser_internal_ArgList_get_next_section.Invoke(&printf_core_FormatSection3, &printf_core_Parser2);
			llvm_memcpy_p0_p0_i64.Invoke(&printf_core_FormatSection2, &printf_core_FormatSection3, 73L, isVolatile: false);
			llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection3);
		}
		llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection2);
		if (num2 == 2)
		{
			result = printf_core_Writer_get_chars_written.Invoke(writer);
		}
		llvm_lifetime_end_p0.Invoke(4L, &num);
		printf_core_Parser_internal_ArgList_Parser.Invoke(&printf_core_Parser2);
		llvm_lifetime_end_p0.Invoke(328L, &printf_core_Parser2);
		return result;
	}
}
