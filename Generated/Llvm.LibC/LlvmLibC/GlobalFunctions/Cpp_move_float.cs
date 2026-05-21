using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRfEEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<float&>::type&& __llvm_libc_20_1_2_::cpp::move<float&>(float&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<float&>::type&&")]
	public unsafe static void* Invoke([MangledName("t")][NativeType("float&")] void* T)
	{
		return T;
	}
}
