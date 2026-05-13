using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIdlEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) == sizeof (long) && cpp::is_trivially_constructible<double>::value && cpp::is_trivially_copyable<double>::value && cpp::is_trivially_copyable<long>::value, double>::type __llvm_libc_20_1_2_::cpp::bit_cast<double, long>(long const&)")]
internal static partial class cpp_enable_if_sizeof_double_sizeof_long_cpp_is_trivially_constructible_double_value_cpp_is_trivially_copyable_double_value_cpp_is_trivially_copyable_long_value_double_type_cpp_bit_cast_double_long_long_const
{
	public unsafe static double Invoke(void* from)
	{
		return *unchecked((double*)from);
	}
}
