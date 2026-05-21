using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_8ul_get
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm8EE3getEm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>::get(unsigned long) const")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned long")] long i)
	{
		return ArrayFixedSize_8ul_get_internal.Invoke(@this, i);
	}
}
