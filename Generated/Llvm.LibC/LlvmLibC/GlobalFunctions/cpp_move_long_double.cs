using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_move_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIReEEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<long double&>::type&& __llvm_libc_20_1_2_::cpp::move<long double&>(long double&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<long double&>::type&&")]
	public unsafe static void* Invoke([NativeType("long double&")] void* t)
	{
		return t;
	}
}
