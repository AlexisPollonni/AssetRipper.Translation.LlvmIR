using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Span_char_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4spanIcEC2EPcm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::span(char*, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] Cpp_string_view* This, [MangledName("first")][NativeType("char*")] void* First, [MangledName("count")][NativeType("unsigned long")] long Count)
	{
		This->Span_data = First;
		This->Span_size = Count;
	}
}
