using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_countl_zero_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countl_zeroIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::cpp::countl_zero<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type")]
	public static int Invoke([NativeType("unsigned char")] sbyte value)
	{
		sbyte b = value;
		return InstructionHelper.Select(b == 0, 8, unchecked((byte)llvm_ctlz_i8.Invoke(b, parameter_1: true)));
	}
}
