using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_forward_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIDF16_EEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("_Float16&& __llvm_libc_20_1_2_::cpp::forward<_Float16>(__llvm_libc_20_1_2_::cpp::remove_reference<_Float16>::type&)")]
	[return: NativeType("_Float16&&")]
	public unsafe static void* Invoke([MangledName("value")][NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<_Float16>::type&")] void* Value)
	{
		return Value;
	}
}
