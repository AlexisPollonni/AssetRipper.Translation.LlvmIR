using System;
using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIoeEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned __int128) == sizeof (long double) && cpp::is_trivially_constructible<unsigned __int128>::value && cpp::is_trivially_copyable<unsigned __int128>::value && cpp::is_trivially_copyable<long double>::value, unsigned __int128>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned __int128, long double>(long double const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_int128_sizeof_long_double_cpp_is_trivially_constructible_unsigned_int128_value_cpp_is_trivially_copyable_unsigned_int128_value_cpp_is_trivially_copyable_long_double_value_unsigned_int128_type_cpp_bit_cast_unsigned_int128_long_double_long_double_const
{
	public unsafe static Struct_fiz2nb Invoke(void* from)
	{
		unchecked
		{
			Int128 @int = *(Int128*)from;
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
