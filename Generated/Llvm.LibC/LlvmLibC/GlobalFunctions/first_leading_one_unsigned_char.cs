using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class first_leading_one_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17first_leading_oneIhEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::first_leading_one<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type")]
	public static int Invoke([NativeType("unsigned char")] sbyte value)
	{
		return first_leading_zero_unsigned_char.Invoke(unchecked((sbyte)((byte)value ^ -1)));
	}
}
