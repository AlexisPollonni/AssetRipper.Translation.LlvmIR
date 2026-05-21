using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Span_char_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp4spanIcEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_string_view* This, [MangledName("index")][NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)Span_char_data.Invoke(This)) + Index;
	}
}
