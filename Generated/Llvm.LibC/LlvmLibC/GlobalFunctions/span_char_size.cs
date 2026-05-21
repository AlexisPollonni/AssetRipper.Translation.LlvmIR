using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class span_char_size
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp4spanIcE4sizeEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::span<char>::size() const")]
	public unsafe static long Invoke(cpp_string_view* @this)
	{
		return @this->span_size;
	}
}
