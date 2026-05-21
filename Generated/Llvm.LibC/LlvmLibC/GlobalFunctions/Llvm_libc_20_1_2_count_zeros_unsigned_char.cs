using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_count_zeros_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11count_zerosIhEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::count_zeros<unsigned char>(unsigned char)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned char")] sbyte Value)
	{
		return Cpp_popcount_unsigned_char.Invoke(unchecked((sbyte)((byte)Value ^ -1)));
	}
}
