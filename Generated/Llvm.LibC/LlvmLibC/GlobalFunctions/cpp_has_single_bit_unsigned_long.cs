using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_has_single_bit_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp14has_single_bitImEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEbE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, bool>::type __llvm_libc_20_1_2_::cpp::has_single_bit<unsigned long>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, bool>::type")]
	public static bool Invoke([NativeType("unsigned long")] long value)
	{
		return value != 0L && (value & unchecked(value - 1L)) == 0L;
	}
}
