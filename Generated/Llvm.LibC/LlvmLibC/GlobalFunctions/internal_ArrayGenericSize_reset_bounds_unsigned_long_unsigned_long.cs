using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal16ArrayGenericSize12reset_boundsEmm")]
[DemangledName("__llvm_libc_20_1_2_::internal::ArrayGenericSize::reset_bounds(unsigned long, unsigned long)")]
internal static partial class internal_ArrayGenericSize_reset_bounds_unsigned_long_unsigned_long
{
	public unsafe static void Invoke(void* @this, long i, long s)
	{
		unchecked
		{
			((scanf_core_ReadBuffer*)@this)->buffer = internal_ArrayGenericSize_get_internal_unsigned_long_const.Invoke(@this, i);
			((scanf_core_ReadBuffer*)@this)->buff_len = s;
		}
	}
}
