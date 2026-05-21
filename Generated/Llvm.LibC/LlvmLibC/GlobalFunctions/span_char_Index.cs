using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class span_char_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp4spanIcEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::operator[](unsigned long) const")]
	public unsafe static void* Invoke(cpp_string_view* @this, [NativeType("unsigned long")] long index)
	{
		return unchecked((byte*)span_char_data.Invoke(@this)) + index;
	}
}
