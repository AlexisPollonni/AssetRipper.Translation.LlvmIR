using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Intrinsics.Unimplemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_printf_main
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core11printf_mainEPNS0_6WriterEPKcRNS_8internal7ArgListE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::printf_main(__llvm_libc_20_1_2_::printf_core::Writer*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Llvm_libc_20_1_2_printf_core_Writer* Writer, [MangledName("str")][NativeType("char const*")] void* Str, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] Llvm_libc_20_1_2_internal_ArgList* Args)
	{
		int result = 0;
		Llvm_libc_20_1_2_printf_core_Parser llvm_libc_20_1_2_printf_core_Parser = default(Llvm_libc_20_1_2_printf_core_Parser);
		int num = 0;
		Llvm_libc_20_1_2_printf_core_FormatSection llvm_libc_20_1_2_printf_core_FormatSection = default(Llvm_libc_20_1_2_printf_core_FormatSection);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_printf_core_FormatSection llvm_libc_20_1_2_printf_core_FormatSection2 = default(Llvm_libc_20_1_2_printf_core_FormatSection);
		Llvm_lifetime_start_p0.Invoke(328L, &llvm_libc_20_1_2_printf_core_Parser);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_Parser, -86, 328L, isVolatile: false);
		Parser_internal_ArgList_Constructor_hus89e.Invoke(&llvm_libc_20_1_2_printf_core_Parser, Str, Args);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection, -86, 80L, isVolatile: false);
		Parser_internal_ArgList_get_next_section.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection, &llvm_libc_20_1_2_printf_core_Parser);
		int num2;
		while (true)
		{
			if (!InstructionHelper.BooleanXor(String_view_empty.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection.Raw_string), right: true))
			{
				num2 = 2;
				break;
			}
			if ((llvm_libc_20_1_2_printf_core_FormatSection.Has_conv & 1) == 1)
			{
				num = Printf_core_convert.Invoke(Writer, &llvm_libc_20_1_2_printf_core_FormatSection);
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_string_view, &llvm_libc_20_1_2_printf_core_FormatSection.Raw_string, 16L, isVolatile: false);
				num = unchecked(Writer_write.Invoke(Writer, *(void**)(&llvm_libc_20_1_2_cpp_string_view), ((long*)(&llvm_libc_20_1_2_cpp_string_view))[1]));
			}
			if (num < 0)
			{
				result = num;
				num2 = 1;
				break;
			}
			Llvm_lifetime_start_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection2);
			Parser_internal_ArgList_get_next_section.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection2, &llvm_libc_20_1_2_printf_core_Parser);
			Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_printf_core_FormatSection, &llvm_libc_20_1_2_printf_core_FormatSection2, 73L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection2);
		}
		Llvm_lifetime_end_p0.Invoke(80L, &llvm_libc_20_1_2_printf_core_FormatSection);
		if (num2 == 2)
		{
			result = Writer_get_chars_written.Invoke(Writer);
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Parser_internal_ArgList_Destructor_r887hg.Invoke(&llvm_libc_20_1_2_printf_core_Parser);
		Llvm_lifetime_end_p0.Invoke(328L, &llvm_libc_20_1_2_printf_core_Parser);
		return result;
	}
}
