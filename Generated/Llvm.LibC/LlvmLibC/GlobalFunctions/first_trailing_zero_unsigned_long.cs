using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class first_trailing_zero_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_19first_trailing_zeroImEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type __llvm_libc_20_1_2_::first_trailing_zero<unsigned long>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, int>::type")]
	public static int Invoke([NativeType("unsigned long")] long value)
	{
		return (value != integer_impl_unsigned_long_0ul_18446744073709551615ul_max.Invoke()) ? (cpp_countr_zero_unsigned_long.Invoke(value ^ -1L) + 1) : 0;
	}
}
