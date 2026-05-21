using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_width_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp9bit_widthItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::cpp::bit_width<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type")]
	public static int Invoke([NativeType("unsigned short")] short value)
	{
		return 16 - cpp_countl_zero_unsigned_short.Invoke(value);
	}
}
