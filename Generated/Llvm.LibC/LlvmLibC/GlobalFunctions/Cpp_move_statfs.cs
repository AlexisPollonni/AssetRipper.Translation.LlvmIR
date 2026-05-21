using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_statfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIR6statfsEEONS0_16remove_referenceIT_E4typeEOS5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<statfs&>::type&& __llvm_libc_20_1_2_::cpp::move<statfs&>(statfs&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<statfs&>::type&&")]
	public unsafe static Statfs* Invoke([MangledName("t")][NativeType("statfs&")] Statfs* T)
	{
		return T;
	}
}
