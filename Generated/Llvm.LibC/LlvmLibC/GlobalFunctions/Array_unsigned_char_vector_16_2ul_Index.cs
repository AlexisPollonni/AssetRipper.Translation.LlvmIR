using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Array_unsigned_char_vector_16_2ul_Index
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIDv16_hLm2EEixEm")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>::operator[](unsigned long)")]
	public unsafe static void* Invoke([MangledName("this")] void* This, [NativeType("unsigned long")] long Index)
	{
		return unchecked((byte*)(&((Llvm_libc_20_1_2_cpp_array_ueviby*)This)->Data) + (nint)Index * sizeof(InlineArray16_SByte));
	}
}
