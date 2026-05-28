using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_int_32ul_Index
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayIjLm32EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned int, 32ul>::operator[](unsigned long) const")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_xx2b9m* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data) + (nint)Index * 4);
	}
}
