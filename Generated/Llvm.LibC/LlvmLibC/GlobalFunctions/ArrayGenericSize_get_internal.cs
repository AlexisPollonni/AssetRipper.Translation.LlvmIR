using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_get_internal
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal16ArrayGenericSize12get_internalEm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::get_internal(unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return unchecked((byte*)((Scanf_core_ReadBuffer*)This)->Buffer + I * ((Scanf_core_ReadBuffer*)This)->Buff_cur);
	}
}
