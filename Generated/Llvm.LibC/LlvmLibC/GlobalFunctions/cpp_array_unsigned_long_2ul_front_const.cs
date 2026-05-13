using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp5arrayImLm2EE5frontEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>::front() const")]
internal static partial class cpp_array_unsigned_long_2ul_front_const
{
	public unsafe static void* Invoke(cpp_array_i3937k* @this)
	{
		return &@this->Data;
	}
}
