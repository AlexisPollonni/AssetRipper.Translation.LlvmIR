using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_width_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_widthIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::cpp::bit_width<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type")]
	public static int Invoke([NativeType("unsigned char")] sbyte value)
	{
		return 8 - cpp_countl_zero_unsigned_char.Invoke(value);
	}
}
