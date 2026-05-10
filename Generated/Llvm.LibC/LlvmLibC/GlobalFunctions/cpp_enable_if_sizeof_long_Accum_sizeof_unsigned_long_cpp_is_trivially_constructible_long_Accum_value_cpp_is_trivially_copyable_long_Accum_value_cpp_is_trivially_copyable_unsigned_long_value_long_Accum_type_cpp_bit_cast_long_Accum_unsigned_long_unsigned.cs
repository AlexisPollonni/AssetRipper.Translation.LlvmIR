using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDAlmEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long _Accum) == sizeof (unsigned long) && cpp::is_trivially_constructible<long _Accum>::value && cpp::is_trivially_copyable<long _Accum>::value && cpp::is_trivially_copyable<unsigned long>::value, long _Accum>::type __llvm_libc_20_1_2_::cpp::bit_cast<long _Accum, unsigned long>(unsigned long const&)")]
internal static partial class cpp_enable_if_sizeof_long_Accum_sizeof_unsigned_long_cpp_is_trivially_constructible_long_Accum_value_cpp_is_trivially_copyable_long_Accum_value_cpp_is_trivially_copyable_unsigned_long_value_long_Accum_type_cpp_bit_cast_long_Accum_unsigned_long_unsigned_long_const
{
	public unsafe static long Invoke(void* from)
	{
		return *unchecked((long*)from);
	}
}
