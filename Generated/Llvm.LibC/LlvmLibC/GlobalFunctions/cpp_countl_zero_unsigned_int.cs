using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_countl_zero_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countl_zeroIjEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::cpp::countl_zero<unsigned int>(unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type")]
	public static int Invoke([NativeType("unsigned int")] int value)
	{
		return InstructionHelper.Select(value == 0, 32, llvm_ctlz_i32.Invoke(value, parameter_1: true));
	}
}
