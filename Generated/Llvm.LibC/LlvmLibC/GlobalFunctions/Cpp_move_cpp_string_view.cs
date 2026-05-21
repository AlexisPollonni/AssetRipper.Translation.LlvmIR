using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_move_cpp_string_view
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp4moveIRNS0_11string_viewEEEONS0_16remove_referenceIT_E4typeEOS5_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::cpp::string_view&>::type&& __llvm_libc_20_1_2_::cpp::move<__llvm_libc_20_1_2_::cpp::string_view&>(__llvm_libc_20_1_2_::cpp::string_view&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::cpp::string_view&>::type&&")]
	public unsafe static void* Invoke([MangledName("t")][NativeType("__llvm_libc_20_1_2_::cpp::string_view&")] void* T)
	{
		return T;
	}
}
