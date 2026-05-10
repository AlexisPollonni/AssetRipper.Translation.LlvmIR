using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_19first_trailing_zeroIhEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned char>, int>::type __llvm_libc_20_1_2_::first_trailing_zero<unsigned char>(unsigned char)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_char_int_type_first_trailing_zero_unsigned_char_unsigned_char
{
	public static int Invoke(sbyte value)
	{
		sbyte b = value;
		return unchecked((byte)b != (byte)cpp_internal_integer_impl_unsigned_char_unsigned_char_0_unsigned_char_255_max.Invoke()) ? (cpp_enable_if_cpp_is_unsigned_v_unsigned_char_int_type_cpp_countr_zero_unsigned_char_unsigned_char.Invoke(unchecked((sbyte)((byte)b ^ -1))) + 1) : 0;
	}
}
