using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_16ul_len
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm16EE3lenEv")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>::len() const")]
	public unsafe static long Invoke(void* @this)
	{
		return unchecked((cpp_string_view*)@this)->span_size;
	}
}
