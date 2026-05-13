using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIPvS2_EENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS4_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valuesr3cpp21is_trivially_copyableIS5_EE5valueES4_E4typeERKS5_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (void*) == sizeof (void*) && cpp::is_trivially_constructible<void*>::value && cpp::is_trivially_copyable<void*>::value && cpp::is_trivially_copyable<void*>::value, void*>::type __llvm_libc_20_1_2_::cpp::bit_cast<void*, void*>(void* const&)")]
internal static partial class cpp_enable_if_sizeof_void_sizeof_void_cpp_is_trivially_constructible_void_value_cpp_is_trivially_copyable_void_value_cpp_is_trivially_copyable_void_value_void_type_cpp_bit_cast_void_void_void_const
{
	public unsafe static void* Invoke(void* from)
	{
		return *unchecked((void**)from);
	}
}
