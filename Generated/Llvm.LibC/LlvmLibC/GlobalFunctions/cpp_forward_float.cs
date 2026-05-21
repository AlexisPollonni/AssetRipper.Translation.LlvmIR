using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_float
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIfEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("float&& __llvm_libc_20_1_2_::cpp::forward<float>(__llvm_libc_20_1_2_::cpp::remove_reference<float>::type&)")]
	[return: NativeType("float&&")]
	public unsafe static void* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<float>::type&")] void* value)
	{
		return value;
	}
}
