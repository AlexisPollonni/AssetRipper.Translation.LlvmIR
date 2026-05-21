using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_int_1ul_Index_9mw8rm
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIjLm1EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 1ul>::operator[](unsigned long) const")]
	[CleanName("Array_unsigned_int_1ul_Index")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_array_2v7m9i* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * 4);
	}
}
