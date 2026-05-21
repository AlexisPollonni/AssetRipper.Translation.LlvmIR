using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class first_leading_one_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17first_leading_oneImEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type __llvm_libc_20_1_2_::first_leading_one<unsigned long>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type")]
	public static int Invoke([NativeType("unsigned long")] long value)
	{
		return first_leading_zero_unsigned_long.Invoke(value ^ -1L);
	}
}
