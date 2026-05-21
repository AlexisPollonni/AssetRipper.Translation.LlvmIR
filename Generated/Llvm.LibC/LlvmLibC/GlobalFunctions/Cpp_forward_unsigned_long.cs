using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardImEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("unsigned long&& __llvm_libc_20_1_2_::cpp::forward<unsigned long>(__llvm_libc_20_1_2_::cpp::remove_reference<unsigned long>::type&)")]
	[return: NativeType("unsigned long&&")]
	public unsafe static void* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<unsigned long>::type&")] void* Value)
	{
		return Value;
	}
}
