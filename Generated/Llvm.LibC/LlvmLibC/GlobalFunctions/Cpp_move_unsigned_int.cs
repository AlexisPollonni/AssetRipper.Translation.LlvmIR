using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRjEEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<unsigned int&>::type&& __llvm_libc_20_1_2_::cpp::move<unsigned int&>(unsigned int&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<unsigned int&>::type&&")]
	public unsafe static void* Invoke([MangledName("t")][NativeType("unsigned int&")] void* T)
	{
		return T;
	}
}
