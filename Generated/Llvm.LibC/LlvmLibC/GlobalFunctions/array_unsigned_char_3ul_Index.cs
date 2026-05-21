using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_char_3ul_Index
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIhLm3EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>::operator[](unsigned long)")]
	public unsafe static void* Invoke(cpp_array_txpwtz* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&@this->Data)) + Index;
	}
}
