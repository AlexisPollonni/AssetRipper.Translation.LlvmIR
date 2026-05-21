using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardIxEEOT_RNS0_16remove_referenceIS2_E4typeE")]
	[DemangledName("long long&& __llvm_libc_20_1_2_::cpp::forward<long long>(__llvm_libc_20_1_2_::cpp::remove_reference<long long>::type&)")]
	[return: NativeType("long long&&")]
	public unsafe static void* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<long long>::type&")] void* value)
	{
		return value;
	}
}
