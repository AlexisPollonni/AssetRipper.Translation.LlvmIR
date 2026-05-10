using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIiiEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (int) == sizeof (int) && cpp::is_trivially_constructible<int>::value && cpp::is_trivially_copyable<int>::value && cpp::is_trivially_copyable<int>::value, int>::type __llvm_libc_20_1_2_::cpp::bit_cast<int, int>(int const&)")]
internal static partial class cpp_enable_if_sizeof_int_sizeof_int_cpp_is_trivially_constructible_int_value_cpp_is_trivially_copyable_int_value_cpp_is_trivially_copyable_int_value_int_type_cpp_bit_cast_int_int_int_const
{
	public unsafe static int Invoke(void* from)
	{
		return *unchecked((int*)from);
	}
}
