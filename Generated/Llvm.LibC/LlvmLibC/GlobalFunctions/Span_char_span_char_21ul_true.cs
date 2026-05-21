using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Span_char_span_char_21ul_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2IcLm21ETnNS0_9enable_ifIX15is_compatible_vIT_EEbE4typeELb1EEERNS0_5arrayIS5_XT0_EEE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span<char, 21ul, true>(__llvm_libc_20_1_2_::cpp::array<char, 21ul>&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_string_view* This, [MangledName("arr")][NativeType("__llvm_libc_20_1_2_::cpp::array<char, 21ul>&")] Llvm_libc_20_1_2_cpp_array_qkm4kn* Arr)
	{
		This->Span_data = Array_char_21ul_data_cchks6.Invoke(Arr);
		This->Span_size = Array_char_21ul_size.Invoke(Arr);
	}
}
