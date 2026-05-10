using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIjDAjEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned int) == sizeof (unsigned _Accum) && cpp::is_trivially_constructible<unsigned int>::value && cpp::is_trivially_copyable<unsigned int>::value && cpp::is_trivially_copyable<unsigned _Accum>::value, unsigned int>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned int, unsigned _Accum>(unsigned _Accum const&)")]
internal static partial class cpp_enable_if_sizeof_unsigned_int_sizeof_unsigned_Accum_cpp_is_trivially_constructible_unsigned_int_value_cpp_is_trivially_copyable_unsigned_int_value_cpp_is_trivially_copyable_unsigned_Accum_value_unsigned_int_type_cpp_bit_cast_unsigned_int_unsigned_Accum_unsigned_Accum_const
{
	public unsafe static int Invoke(void* from)
	{
		return *unchecked((int*)from);
	}
}
