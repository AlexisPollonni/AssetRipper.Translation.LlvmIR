using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Span_char_span_char_true
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2IcTnNS0_9enable_ifIX15is_compatible_vIT_EEbE4typeELb1EEERNS1_IS5_EE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span<char, true>(__llvm_libc_20_1_2_::cpp::span<char>&)")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_string_view* This, [MangledName("s")][NativeType("__llvm_libc_20_1_2_::cpp::span<char>&")] Llvm_libc_20_1_2_cpp_string_view* S)
	{
		This->Span_data = Span_char_data.Invoke(S);
		This->Span_size = Span_char_size.Invoke(S);
	}
}
