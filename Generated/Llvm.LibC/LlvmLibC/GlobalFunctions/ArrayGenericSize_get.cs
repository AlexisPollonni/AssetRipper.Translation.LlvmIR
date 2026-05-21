using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_get
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize3getEm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::get(unsigned long) const")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned long")] long i)
	{
		return ArrayGenericSize_get_internal.Invoke(@this, i);
	}
}
