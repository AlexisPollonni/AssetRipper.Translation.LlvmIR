using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_move_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRxEEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<long long&>::type&& __llvm_libc_20_1_2_::cpp::move<long long&>(long long&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<long long&>::type&&")]
	public unsafe static void* Invoke([NativeType("long long&")] void* t)
	{
		return t;
	}
}
