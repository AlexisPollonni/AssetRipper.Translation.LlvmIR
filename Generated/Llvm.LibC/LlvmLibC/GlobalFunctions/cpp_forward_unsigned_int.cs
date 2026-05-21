using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIjEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("unsigned int&& __llvm_libc_20_1_2_::cpp::forward<unsigned int>(__llvm_libc_20_1_2_::cpp::remove_reference<unsigned int>::type&)")]
	[return: NativeType("unsigned int&&")]
	public unsafe static void* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<unsigned int>::type&")] void* value)
	{
		return value;
	}
}
