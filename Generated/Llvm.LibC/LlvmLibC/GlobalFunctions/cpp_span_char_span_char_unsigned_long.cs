using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2EPcm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span(char*, unsigned long)")]
internal static partial class cpp_span_char_span_char_unsigned_long
{
	public unsafe static void Invoke(cpp_string_view* @this, void* first, long count)
	{
		@this->span_data = first;
		@this->span_size = count;
	}
}
