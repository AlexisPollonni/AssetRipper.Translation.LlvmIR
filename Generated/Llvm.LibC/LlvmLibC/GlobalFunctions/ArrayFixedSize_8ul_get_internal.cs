using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ArrayFixedSize_8ul_get_internal
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_8internal14ArrayFixedSizeILm8EE12get_internalEm")]
	[DemangledName("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>::get_internal(unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [MangledName("i")][NativeType("unsigned long")] long I)
	{
		return unchecked((byte*)((Cpp_string_view*)This)->Span_data + I * 8L);
	}
}
