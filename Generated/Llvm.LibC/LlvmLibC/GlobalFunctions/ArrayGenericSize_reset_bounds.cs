using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayGenericSize_reset_bounds
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal16ArrayGenericSize12reset_boundsEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::reset_bounds(unsigned long, unsigned long)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned long")] long i, [NativeType("unsigned long")] long s)
	{
		unchecked
		{
			((scanf_core_ReadBuffer*)@this)->buffer = ArrayGenericSize_get_internal.Invoke(@this, i);
			((scanf_core_ReadBuffer*)@this)->buff_len = s;
		}
	}
}
