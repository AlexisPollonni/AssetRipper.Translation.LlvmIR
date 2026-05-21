using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRmEEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<unsigned long&>::type&& __llvm_libc_20_1_2_::cpp::move<unsigned long&>(unsigned long&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<unsigned long&>::type&&")]
	public unsafe static void* Invoke([MangledName("t")][NativeType("unsigned long&")] void* T)
	{
		return T;
	}
}
