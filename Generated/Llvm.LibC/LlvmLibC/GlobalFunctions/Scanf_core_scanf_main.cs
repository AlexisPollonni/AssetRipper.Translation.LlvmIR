using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_scanf_main
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core10scanf_mainEPNS0_6ReaderEPKcRNS_8internal7ArgListE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::scanf_main(__llvm_libc_20_1_2_::scanf_core::Reader*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	public unsafe static int Invoke([MangledName("reader")][NativeType("__llvm_libc_20_1_2_::scanf_core::Reader*")] Scanf_core_Reader* Reader, [MangledName("str")][NativeType("char const*")] void* Str, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] Internal_ArgList* Args)
	{
		Scanf_core_Parser scanf_core_Parser = default(Scanf_core_Parser);
		int num = 0;
		int num2 = 0;
		Scanf_core_FormatSection scanf_core_FormatSection = default(Scanf_core_FormatSection);
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		Scanf_core_FormatSection scanf_core_FormatSection2 = default(Scanf_core_FormatSection);
		Llvm_lifetime_start_p0.Invoke(72L, &scanf_core_Parser);
		Llvm_memset_p0_i64.Invoke(&scanf_core_Parser, -86, 72L, isVolatile: false);
		Parser_internal_ArgList_Constructor_ch3m7r.Invoke(&scanf_core_Parser, Str, Args);
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		Llvm_lifetime_start_p0.Invoke(88L, &scanf_core_FormatSection);
		Llvm_memset_p0_i64.Invoke(&scanf_core_FormatSection, -86, 88L, isVolatile: false);
		Parser_internal_ArgList_get_next_section.Invoke(&scanf_core_FormatSection, &scanf_core_Parser);
		while (!String_view_empty.Invoke(&scanf_core_FormatSection.Raw_string) && num == 0)
		{
			if ((scanf_core_FormatSection.Has_conv & 1) == 1)
			{
				num = Scanf_core_convert.Invoke(Reader, &scanf_core_FormatSection);
				if (scanf_core_FormatSection.Conv_name != 110)
				{
					int num3 = InstructionHelper.Select(num == 0, 1, 0);
					num2 += num3;
				}
			}
			else
			{
				Llvm_memcpy_p0_p0_i64.Invoke(&cpp_string_view, &scanf_core_FormatSection.Raw_string, 16L, isVolatile: false);
				num = unchecked(Scanf_core_raw_match.Invoke(Reader, *(void**)(&cpp_string_view), ((long*)(&cpp_string_view))[1]));
			}
			Llvm_lifetime_start_p0.Invoke(88L, &scanf_core_FormatSection2);
			Parser_internal_ArgList_get_next_section.Invoke(&scanf_core_FormatSection2, &scanf_core_Parser);
			Llvm_memcpy_p0_p0_i64.Invoke(&scanf_core_FormatSection, &scanf_core_FormatSection2, 88L, isVolatile: false);
			Llvm_lifetime_end_p0.Invoke(88L, &scanf_core_FormatSection2);
		}
		Llvm_lifetime_end_p0.Invoke(88L, &scanf_core_FormatSection);
		int result = num2;
		Llvm_lifetime_end_p0.Invoke(4L, &num2);
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Parser_internal_ArgList_Destructor_crcdb5.Invoke(&scanf_core_Parser);
		Llvm_lifetime_end_p0.Invoke(72L, &scanf_core_Parser);
		return result;
	}
}
