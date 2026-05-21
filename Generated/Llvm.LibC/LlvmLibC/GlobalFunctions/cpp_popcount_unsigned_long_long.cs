using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_popcount_unsigned_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8popcountIyEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, int>::type __llvm_libc_20_1_2_::cpp::popcount<unsigned long long>(unsigned long long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, int>::type")]
	public static int Invoke([NativeType("unsigned long long")] long value)
	{
		return unchecked((int)llvm_ctpop_i64.Invoke(value));
	}
}
