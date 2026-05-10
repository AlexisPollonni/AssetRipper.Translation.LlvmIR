using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp10countr_oneItEENS0_9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::cpp::countr_one<unsigned short>(unsigned short)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_cpp_countr_one_unsigned_short_unsigned_short
{
	public static int Invoke(short value)
	{
		return cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_cpp_countr_zero_unsigned_short_unsigned_short.Invoke(unchecked((short)((ushort)value ^ -1)));
	}
}
