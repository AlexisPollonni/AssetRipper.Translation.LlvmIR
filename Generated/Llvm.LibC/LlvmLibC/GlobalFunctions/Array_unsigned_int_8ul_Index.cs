using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_int_8ul_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIjLm8EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 8ul>::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&((Cpp_array_wwfw4y*)This)->Data) + (nint)Index * 4);
	}
}
