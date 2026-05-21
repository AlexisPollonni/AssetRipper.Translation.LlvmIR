using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_8ul_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm8EEC2EPvm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>::ArrayFixedSize(void*, unsigned long)")]
	public unsafe static void Invoke(void* @this, [NativeType("void*")] void* a, [NativeType("unsigned long")] long s)
	{
		unchecked
		{
			((cpp_string_view*)@this)->span_data = a;
			((cpp_string_view*)@this)->span_size = s;
		}
	}
}
