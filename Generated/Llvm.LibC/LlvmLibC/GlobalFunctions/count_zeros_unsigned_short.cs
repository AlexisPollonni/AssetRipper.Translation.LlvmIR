using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class count_zeros_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11count_zerosItEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::count_zeros<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type")]
	public static int Invoke([NativeType("unsigned short")] short value)
	{
		return cpp_popcount_unsigned_short.Invoke(unchecked((short)((ushort)value ^ -1)));
	}
}
