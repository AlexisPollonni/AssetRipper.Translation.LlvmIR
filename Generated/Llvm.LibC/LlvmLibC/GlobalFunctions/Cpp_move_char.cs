using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRPcEEONS0_16remove_referenceIT_E4typeEOS5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<char*&>::type&& __llvm_libc_20_1_2_::cpp::move<char*&>(char*&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<char*&>::type&&")]
	public unsafe static void* Invoke([MangledName("t")][NativeType("char*&")] void* T)
	{
		return T;
	}
}
