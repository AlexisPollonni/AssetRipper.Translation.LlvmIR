using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIiEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("int&& __llvm_libc_20_1_2_::cpp::forward<int>(__llvm_libc_20_1_2_::cpp::remove_reference<int>::type&)")]
	[return: NativeType("int&&")]
	public unsafe static void* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<int>::type&")] void* Value)
	{
		return Value;
	}
}
