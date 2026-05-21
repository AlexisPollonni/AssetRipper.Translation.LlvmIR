using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class array_unsigned_char_vector_16_4ul_Index
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIDv16_hLm4EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 4ul>::operator[](unsigned long)")]
	public unsafe static void* Invoke(void* @this, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&((cpp_array_2b9gdz*)@this)->Data) + (nint)Index * sizeof(InlineArray16_SByte));
	}
}
