using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_11count_zerosItEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::count_zeros<unsigned short>(unsigned short)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_count_zeros_unsigned_short_unsigned_short
{
	public static int Invoke(short value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_cpp_popcount_unsigned_short_unsigned_short.Invoke(unchecked((short)((ushort)value ^ -1)));
	}
}
