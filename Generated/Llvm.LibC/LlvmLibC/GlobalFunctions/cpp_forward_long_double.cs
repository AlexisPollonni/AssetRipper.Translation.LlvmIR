using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIeEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("long double&& __llvm_libc_20_1_2_::cpp::forward<long double>(__llvm_libc_20_1_2_::cpp::remove_reference<long double>::type&)")]
	[return: NativeType("long double&&")]
	public unsafe static void* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<long double>::type&")] void* value)
	{
		return value;
	}
}
