using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_4ul_reset_bounds
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EE12reset_boundsEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::reset_bounds(unsigned long, unsigned long)")]
	public unsafe static void Invoke(void* @this, [NativeType("unsigned long")] long i, [NativeType("unsigned long")] long s)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = ArrayFixedSize_4ul_get_internal.Invoke(@this, i);
			((cpp_string_view*)@this)->span_size = s;
		}
	}
}
