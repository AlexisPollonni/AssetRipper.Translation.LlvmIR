using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class span_char_span_char_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2IcTnNS0_9enable_ifIX15is_compatible_vIT_EEbE4typeELb1EEERNS1_IS5_EE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span<char, true>(__llvm_libc_20_1_2_::cpp::span<char>&)")]
	public unsafe static void Invoke(cpp_string_view* @this, [NativeType("__llvm_libc_20_1_2_::cpp::span<char>&")] cpp_string_view* s)
	{
		@this->span_data = span_char_data.Invoke(s);
		@this->span_size = span_char_size.Invoke(s);
	}
}
