using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_move_Float16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRDF16_EEONS0_16remove_referenceIT_E4typeEOS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<_Float16&>::type&& __llvm_libc_20_1_2_::cpp::move<_Float16&>(_Float16&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<_Float16&>::type&&")]
	public unsafe static void* Invoke([NativeType("_Float16&")] void* t)
	{
		return t;
	}
}
