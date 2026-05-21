using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_has_single_bit_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp14has_single_bitItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEbE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, bool>::type __llvm_libc_20_1_2_::cpp::has_single_bit<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, bool>::type")]
	public static bool Invoke([MangledName("value")][NativeType("unsigned short")] short Value)
	{
		short num = Value;
		return unchecked((ushort)num) != 0 && (unchecked((ushort)num) & (unchecked((ushort)num) - 1)) == 0;
	}
}
