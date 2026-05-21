using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_move_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRdEEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<double&>::type&& __llvm_libc_20_1_2_::cpp::move<double&>(double&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<double&>::type&&")]
	public unsafe static void* Invoke([NativeType("double&")] void* t)
	{
		return t;
	}
}
