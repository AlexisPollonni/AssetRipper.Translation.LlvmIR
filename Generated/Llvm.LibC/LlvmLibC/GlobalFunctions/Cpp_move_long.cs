using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRlEEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<long&>::type&& __llvm_libc_20_1_2_::cpp::move<long&>(long&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<long&>::type&&")]
	public unsafe static void* Invoke([MangledName("t")][NativeType("long&")] void* T)
	{
		return T;
	}
}
