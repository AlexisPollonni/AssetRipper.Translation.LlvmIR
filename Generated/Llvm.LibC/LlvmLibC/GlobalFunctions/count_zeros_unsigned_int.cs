using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class count_zeros_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11count_zerosIjEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::count_zeros<unsigned int>(unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type")]
	public static int Invoke([NativeType("unsigned int")] int value)
	{
		return cpp_popcount_unsigned_int.Invoke(value ^ -1);
	}
}
