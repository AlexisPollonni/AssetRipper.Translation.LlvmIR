using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIeEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("long double&& __llvm_libc_20_1_2_::cpp::forward<long double>(__llvm_libc_20_1_2_::cpp::remove_reference<long double>::type&)")]
	[return: NativeType("long double&&")]
	public unsafe static void* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<long double>::type&")] void* Value)
	{
		return Value;
	}
}
