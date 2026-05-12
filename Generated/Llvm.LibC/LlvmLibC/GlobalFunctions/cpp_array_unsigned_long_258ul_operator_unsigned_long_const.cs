using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm258EEixEm")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 258ul>::operator[](unsigned long) const")]
internal static partial class cpp_array_unsigned_long_258ul_operator_unsigned_long_const
{
	public unsafe static void* Invoke(cpp_array_vnnqx8* @this, long Index)
	{
		return unchecked((byte*)(&@this->Data) + (nint)Index * 8);
	}
}
