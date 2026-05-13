using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_18first_leading_zeroItEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::first_leading_zero<unsigned short>(unsigned short)")]
internal static partial class cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_first_leading_zero_unsigned_short_unsigned_short
{
	public static int Invoke(short value)
	{
		short num = value;
		return unchecked((ushort)num != (ushort)cpp_internal_integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_max.Invoke()) ? (cpp_enable_if_cpp_is_unsigned_v_unsigned_short_int_type_cpp_countl_one_unsigned_short_unsigned_short.Invoke(num) + 1) : 0;
	}
}
