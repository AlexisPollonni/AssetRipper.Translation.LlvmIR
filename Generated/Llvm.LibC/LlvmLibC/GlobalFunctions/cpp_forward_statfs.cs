using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_forward_statfs
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp7forwardI6statfsEEOT_RNS0_16remove_referenceIS3_E4typeE")]
	[DemangledName("statfs&& __llvm_libc_20_1_2_::cpp::forward<statfs>(__llvm_libc_20_1_2_::cpp::remove_reference<statfs>::type&)")]
	[return: NativeType("statfs&&")]
	public unsafe static statfs* Invoke([NativeType("__llvm_libc_20_1_2_::cpp::remove_reference<statfs>::type&")] statfs* value)
	{
		return value;
	}
}
