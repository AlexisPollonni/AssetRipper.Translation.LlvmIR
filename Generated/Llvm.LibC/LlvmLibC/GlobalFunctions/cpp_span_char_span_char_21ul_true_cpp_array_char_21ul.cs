using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2IcLm21ETnNS0_9enable_ifIX15is_compatible_vIT_EEbE4typeELb1EEERNS0_5arrayIS5_XT0_EEE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span<char, 21ul, true>(__llvm_libc_20_1_2_::cpp::array<char, 21ul>&)")]
internal static partial class cpp_span_char_span_char_21ul_true_cpp_array_char_21ul
{
	public unsafe static void Invoke(void* @this, void* arr)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = cpp_array_char_21ul_data.Invoke(arr);
			((cpp_string_view*)@this)->span_size = cpp_array_char_21ul_size_const.Invoke(arr);
		}
	}
}
