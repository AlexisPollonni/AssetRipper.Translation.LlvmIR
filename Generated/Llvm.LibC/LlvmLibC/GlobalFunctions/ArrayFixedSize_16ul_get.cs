using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_16ul_get
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm16EE3getEm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>::get(unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return ArrayFixedSize_16ul_get_internal.Invoke(This, I);
	}
}
