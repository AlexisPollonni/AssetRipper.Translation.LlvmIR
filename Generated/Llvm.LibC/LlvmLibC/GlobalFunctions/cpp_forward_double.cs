using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIdEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("double&& __llvm_libc_20_1_2_::cpp::forward<double>(__llvm_libc_20_1_2_::cpp::remove_reference<double>::type&)")]
	[return: NativeType("double&&")]
	public unsafe static void* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<double>::type&")] void* value)
	{
		return value;
	}
}
