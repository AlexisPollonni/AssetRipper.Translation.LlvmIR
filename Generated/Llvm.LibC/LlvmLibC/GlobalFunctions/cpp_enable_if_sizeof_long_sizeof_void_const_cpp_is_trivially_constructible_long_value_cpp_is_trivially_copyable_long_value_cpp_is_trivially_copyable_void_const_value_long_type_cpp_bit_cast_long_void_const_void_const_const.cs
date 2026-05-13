using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIlPKvEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS5_EE5valuesr3cpp21is_trivially_copyableIS5_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valueES5_E4typeERKS6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long) == sizeof (void const*) && cpp::is_trivially_constructible<long>::value && cpp::is_trivially_copyable<long>::value && cpp::is_trivially_copyable<void const*>::value, long>::type __llvm_libc_20_1_2_::cpp::bit_cast<long, void const*>(void const* const&)")]
internal static partial class cpp_enable_if_sizeof_long_sizeof_void_const_cpp_is_trivially_constructible_long_value_cpp_is_trivially_copyable_long_value_cpp_is_trivially_copyable_void_const_value_long_type_cpp_bit_cast_long_void_const_void_const_const
{
	public unsafe static long Invoke(void* from)
	{
		return *unchecked((long*)from);
	}
}
