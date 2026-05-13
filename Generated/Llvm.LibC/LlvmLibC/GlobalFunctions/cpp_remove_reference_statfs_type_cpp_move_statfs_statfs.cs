using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIR6statfsEEONS0_16remove_referenceIT_E4typeEOS5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<statfs&>::type&& __llvm_libc_20_1_2_::cpp::move<statfs&>(statfs&)")]
internal static partial class cpp_remove_reference_statfs_type_cpp_move_statfs_statfs
{
	public unsafe static statfs* Invoke(statfs* t)
	{
		return t;
	}
}
