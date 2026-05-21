using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_ceil_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_ceilImEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, unsigned long>::type __llvm_libc_20_1_2_::cpp::bit_ceil<unsigned long>(unsigned long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long>, unsigned long>::type")]
	public static long Invoke([MangledName("value")][NativeType("unsigned long")] long Value)
	{
		unchecked
		{
			if ((ulong)Value < 2uL)
			{
				return 1L;
			}
			return 1L << (int)(uint)Cpp_bit_width_unsigned_long.Invoke(Value - 1L);
		}
	}
}
