using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_popcount_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8popcountIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::cpp::popcount<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type")]
	public static int Invoke([NativeType("unsigned char")] sbyte value)
	{
		return unchecked((byte)llvm_ctpop_i8.Invoke(value));
	}
}
