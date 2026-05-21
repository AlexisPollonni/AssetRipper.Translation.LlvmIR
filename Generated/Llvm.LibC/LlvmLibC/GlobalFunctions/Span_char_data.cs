using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Span_char_data
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp4spanIcE4dataEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::data() const")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_string_view* This)
	{
		return This->Span_data;
	}
}
