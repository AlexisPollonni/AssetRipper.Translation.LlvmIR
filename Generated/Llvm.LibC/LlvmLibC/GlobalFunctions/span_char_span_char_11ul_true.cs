using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class span_char_span_char_11ul_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2IcLm11ETnNS0_9enable_ifIX15is_compatible_vIT_EEbE4typeELb1EEERNS0_5arrayIS5_XT0_EEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span<char, 11ul, true>(__llvm_libc_20_1_2_::cpp::array<char, 11ul>&)")]
	public unsafe static void Invoke(cpp_string_view* @this, [NativeType("__llvm_libc_20_1_2_::cpp::array<char, 11ul>&")] cpp_array_sbzi9g* arr)
	{
		@this->span_data = array_char_11ul_data_fyrfca.Invoke(arr);
		@this->span_size = array_char_11ul_size.Invoke(arr);
	}
}
