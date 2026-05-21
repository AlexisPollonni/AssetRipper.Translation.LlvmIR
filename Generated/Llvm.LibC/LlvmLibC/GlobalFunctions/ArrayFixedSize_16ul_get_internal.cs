using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_16ul_get_internal
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm16EE12get_internalEm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>::get_internal(unsigned long) const")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned long")] long i)
	{
		return unchecked((byte*)((cpp_string_view*)@this)->span_data + i * 16L);
	}
}
