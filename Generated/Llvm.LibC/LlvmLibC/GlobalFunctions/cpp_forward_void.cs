using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_void
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIPvEEOT_RNS0_16remove_referenceIS3_E4typeE")]
	[DemangledName("void*&& __llvm_libc_20_1_2_::cpp::forward<void*>(__llvm_libc_20_1_2_::cpp::remove_reference<void*>::type&)")]
	[return: NativeType("void*&&")]
	public unsafe static void* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<void*>::type&")] void* value)
	{
		return value;
	}
}
