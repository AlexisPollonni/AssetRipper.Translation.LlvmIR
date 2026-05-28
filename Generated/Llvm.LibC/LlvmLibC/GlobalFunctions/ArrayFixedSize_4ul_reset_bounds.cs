using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_4ul_reset_bounds
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm4EE12reset_boundsEmm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>::reset_bounds(unsigned long, unsigned long)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("i")][NativeType("unsigned long")] long I, [MangledName("s")][NativeType("unsigned long")] long S)
	{
		unchecked
		{
			((Cpp_string_view*)This)->Span_data = ArrayFixedSize_4ul_get_internal.Invoke(This, I);
			((Cpp_string_view*)This)->Span_size = S;
		}
	}
}
