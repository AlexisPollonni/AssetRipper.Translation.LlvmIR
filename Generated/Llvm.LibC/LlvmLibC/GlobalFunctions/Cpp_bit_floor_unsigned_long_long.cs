using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_floor_unsigned_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_floorIyEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, unsigned long long>::type __llvm_libc_20_1_2_::cpp::bit_floor<unsigned long long>(unsigned long long)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned long long>, unsigned long long>::type")]
	public static long Invoke([MangledName("value")][NativeType("unsigned long long")] long Value)
	{
		if (Value == 0L)
		{
			return 0L;
		}
		unchecked
		{
			return 1L << (int)(uint)checked(Cpp_bit_width_unsigned_long_long.Invoke(Value) - 1);
		}
	}
}
