using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_countl_zero_unsigned_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp11countl_zeroIyEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, int>::type __llvm_libc_20_1_2_::cpp::countl_zero<unsigned long long>(unsigned long long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, int>::type")]
	public static int Invoke([NativeType("unsigned long long")] long value)
	{
		return InstructionHelper.Select(value == 0L, 64, unchecked((int)llvm_ctlz_i64.Invoke(value, parameter_1: true)));
	}
}
