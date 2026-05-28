using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class First_leading_zero_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_18first_leading_zeroImEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type __llvm_libc_20_1_2_::first_leading_zero<unsigned long>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned long")] long Value)
	{
		return (Value != Integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke()) ? (Cpp_countl_one_unsigned_long.Invoke(Value) + 1) : 0;
	}
}
