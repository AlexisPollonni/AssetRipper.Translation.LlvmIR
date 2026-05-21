using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_popcount_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8popcountImEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type __llvm_libc_20_1_2_::cpp::popcount<unsigned long>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned long")] long Value)
	{
		return unchecked((int)Llvm_ctpop_i64.Invoke(Value));
	}
}
