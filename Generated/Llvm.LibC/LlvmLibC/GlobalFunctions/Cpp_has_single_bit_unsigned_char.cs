using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_has_single_bit_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp14has_single_bitIhEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEbE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, bool>::type __llvm_libc_20_1_2_::cpp::has_single_bit<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, bool>::type")]
	public static bool Invoke([MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		sbyte b = Value;
		return unchecked((byte)b) != 0 && (unchecked((byte)b) & (unchecked((byte)b) - 1)) == 0;
	}
}
