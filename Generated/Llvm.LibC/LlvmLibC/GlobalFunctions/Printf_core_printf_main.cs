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
	public unsafe static int Invoke([MangledName("writer")][NativeType("__llvm_libc_20_1_2_::printf_core::Writer*")] Printf_core_Writer* Writer, [MangledName("str")][NativeType("char const*")] void* Str, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] Internal_ArgList* Args)
	{
		int result = 0;
		Printf_core_Parser printf_core_Parser = default(Printf_core_Parser);
		int num = 0;
		Printf_core_FormatSection printf_core_FormatSection = default(Printf_core_FormatSection);
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Printf_core_FormatSection printf_core_FormatSection2 = default(Printf_core_FormatSection);
		Llvm_lifetime_start_p0.Invoke(328L, &printf_core_Parser);
		Llvm_memset_p0_i64.Invoke(&printf_core_Parser, -86, 328L, isVolatile: false);
		Parser_internal_ArgList_Constructor_hus89e.Invoke(&printf_core_Parser, Str, Args);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection);
		Llvm_memset_p0_i64.Invoke(&printf_core_FormatSection, -86, 80L, isVolatile: false);
		Parser_internal_ArgList_get_next_section.Invoke(&printf_core_FormatSection, &printf_core_Parser);
		int num2;
		while (true)
		{
			if (!InstructionHelper.BooleanXor(String_view_empty.Invoke(&printf_core_FormatSection.Raw_string), right: true))
			{
				num2 = 2;
				break;
			}
			if ((printf_core_FormatSection.Has_conv & 1) == 1)
			{
				num = Printf_core_convert.Invoke(Writer, &printf_core_FormatSection);
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view, &printf_core_FormatSection.Raw_string, 16L, isVolatile: false);
				num = unchecked(Writer_write.Invoke(Writer, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]));
			}
			if (num < 0)
			{
				result = num;
				num2 = 1;
				break;
			}
			Llvm_lifetime_start_p0.Invoke(80L, &printf_core_FormatSection2);
			Parser_internal_ArgList_get_next_section.Invoke(&printf_core_FormatSection2, &printf_core_Parser);
			Llvm_memcpy_p0_p0_i64.Invoke(&printf_core_FormatSection, &printf_core_FormatSection2, 73L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection2);
		}
		Llvm_lifetime_end_p0.Invoke(80L, &printf_core_FormatSection);
		if (num2 == 2)
		{
			result = Writer_get_chars_written.Invoke(Writer);
		}
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Parser_internal_ArgList_Destructor_r887hg.Invoke(&printf_core_Parser);
		Llvm_lifetime_end_p0.Invoke(328L, &printf_core_Parser);
		return result;
	}
}
