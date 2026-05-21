using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIPcEEOT_RNS0_16remove_referenceIS3_E4typeE")]
	[DemangledName("char*&& __llvm_libc_20_1_2_::cpp::forward<char*>(__llvm_libc_20_1_2_::cpp::remove_reference<char*>::type&)")]
	[return: NativeType("char*&&")]
	public unsafe static void* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<char*>::type&")] void* Value)
	{
		return Value;
	}
}
