using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_move_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRiEEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<int&>::type&& __llvm_libc_20_1_2_::cpp::move<int&>(int&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<int&>::type&&")]
	public unsafe static void* Invoke([NativeType("int&")] void* t)
	{
		return t;
	}
}
