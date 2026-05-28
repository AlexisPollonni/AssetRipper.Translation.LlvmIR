using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class First_leading_zero_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_18first_leading_zeroIhEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::first_leading_zero<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		sbyte b = Value;
		return unchecked((byte)b != (byte)Integer_impl_unsigned_char_unsigned_char_0_unsigned_char_255_max.Invoke()) ? (Cpp_countl_one_unsigned_char.Invoke(b) + 1) : 0;
	}
}
