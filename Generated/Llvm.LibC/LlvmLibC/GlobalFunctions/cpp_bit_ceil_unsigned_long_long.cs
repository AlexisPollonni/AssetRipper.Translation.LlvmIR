using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_ceil_unsigned_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_ceilIyEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, unsigned long long>::type __llvm_libc_20_1_2_::cpp::bit_ceil<unsigned long long>(unsigned long long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, unsigned long long>::type")]
	public static long Invoke([NativeType("unsigned long long")] long value)
	{
		unchecked
		{
			if ((ulong)value < 2uL)
			{
				return 1L;
			}
			return 1L << (int)(uint)cpp_bit_width_unsigned_long_long.Invoke(value - 1L);
		}
	}
}
