using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_char_3ul_Index
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIhLm3EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>::operator[](unsigned long)")]
	public unsafe static void* Invoke([MangledName("this")] Cpp_array_txpwtz* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&This->Data)) + Index;
	}
}
