using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2IcTnNS0_9enable_ifIX15is_compatible_vIT_EEbE4typeELb1EEERNS1_IS5_EE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span<char, true>(__llvm_libc_20_1_2_::cpp::span<char>&)")]
internal static partial class cpp_span_char_span_char_true_cpp_span_char
{
	public unsafe static void Invoke(cpp_string_view* @this, cpp_string_view* s)
	{
		@this->span_data = cpp_span_char_data_const.Invoke(s);
		@this->span_size = cpp_span_char_size_const.Invoke(s);
	}
}
