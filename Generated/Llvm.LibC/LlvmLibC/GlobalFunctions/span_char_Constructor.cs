using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class span_char_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2EPcm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span(char*, unsigned long)")]
	public unsafe static void Invoke(cpp_string_view* @this, [NativeType("char*")] void* first, [NativeType("unsigned long")] long count)
	{
		@this->span_data = first;
		@this->span_size = count;
	}
}
