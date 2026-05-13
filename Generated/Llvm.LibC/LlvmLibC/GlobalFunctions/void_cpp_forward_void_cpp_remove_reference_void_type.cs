using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIPvEEOT_RNS0_16remove_referenceIS3_E4typeE")]
[DemangledName("void*&& __llvm_libc_20_1_2_::cpp::forward<void*>(__llvm_libc_20_1_2_::cpp::remove_reference<void*>::type&)")]
internal static partial class void_cpp_forward_void_cpp_remove_reference_void_type
{
	public unsafe static void* Invoke(void* value)
	{
		return value;
	}
}
