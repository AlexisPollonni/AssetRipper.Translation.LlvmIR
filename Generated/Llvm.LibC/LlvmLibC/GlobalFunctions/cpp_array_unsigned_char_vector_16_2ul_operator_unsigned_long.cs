using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp5arrayIDv16_hLm2EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char vector[16], 2ul>::operator[](unsigned long)")]
internal static partial class cpp_array_unsigned_char_vector_16_2ul_operator_unsigned_long
{
	public unsafe static void* Invoke(void* @this, long Index)
	{
		return unchecked((byte*)(&((cpp_array_ueviby*)@this)->Data) + (nint)Index * sizeof(InlineArray16_SByte));
	}
}
