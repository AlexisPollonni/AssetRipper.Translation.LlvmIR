using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_reset_bounds
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal16ArrayGenericSize12reset_boundsEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::reset_bounds(unsigned long, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("i")][NativeType("unsigned long")] long I, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		unchecked
		{
			((Scanf_core_ReadBuffer*)This)->Buffer = ArrayGenericSize_get_internal.Invoke(This, I);
			((Scanf_core_ReadBuffer*)This)->Buff_len = S;
		}
	}
}
