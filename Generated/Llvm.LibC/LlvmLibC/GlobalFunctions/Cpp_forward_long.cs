using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIlEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("long&& __llvm_libc_20_1_2_::cpp::forward<long>(__llvm_libc_20_1_2_::cpp::remove_reference<long>::type&)")]
	[return: NativeType("long&&")]
	public unsafe static void* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<long>::type&")] void* Value)
	{
		return Value;
	}
}
