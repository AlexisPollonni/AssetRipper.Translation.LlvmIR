using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDAijEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Accum) == sizeof (unsigned int) && cpp::is_trivially_constructible<_Accum>::value && cpp::is_trivially_copyable<_Accum>::value && cpp::is_trivially_copyable<unsigned int>::value, _Accum>::type __llvm_libc_20_1_2_::cpp::bit_cast<_Accum, unsigned int>(unsigned int const&)")]
internal static partial class cpp_enable_if_sizeof_Accum_sizeof_unsigned_int_cpp_is_trivially_constructible_Accum_value_cpp_is_trivially_copyable_Accum_value_cpp_is_trivially_copyable_unsigned_int_value_Accum_type_cpp_bit_cast_Accum_unsigned_int_unsigned_int_const
{
	public unsafe static int Invoke(void* from)
	{
		return *unchecked((int*)from);
	}
}
