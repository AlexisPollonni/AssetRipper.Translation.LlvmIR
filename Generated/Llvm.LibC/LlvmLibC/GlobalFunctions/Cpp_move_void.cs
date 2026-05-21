using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_void
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRPvEEONS0_16remove_referenceIT_E4typeEOS5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<void*&>::type&& __llvm_libc_20_1_2_::cpp::move<void*&>(void*&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<void*&>::type&&")]
	public unsafe static void* Invoke([MangledName("t")][NativeType("void*&")] void* T)
	{
		return T;
	}
}
