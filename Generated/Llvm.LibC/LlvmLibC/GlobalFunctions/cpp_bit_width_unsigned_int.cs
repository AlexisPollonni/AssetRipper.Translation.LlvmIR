using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_width_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_widthIjEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::cpp::bit_width<unsigned int>(unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type")]
	public static int Invoke([NativeType("unsigned int")] int value)
	{
		return 32 - cpp_countl_zero_unsigned_int.Invoke(value);
	}
}
