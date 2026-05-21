using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_cpp_string_view
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardINS0_11string_viewEEEOT_RNS0_16remove_referenceIS3_E4typeE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::string_view&& __llvm_libc_20_1_2_::cpp::forward<__llvm_libc_20_1_2_::cpp::string_view>(__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::cpp::string_view>::type&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::string_view&&")]
	public unsafe static void* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<__llvm_libc_20_1_2_::cpp::string_view>::type&")] void* value)
	{
		return value;
	}
}
