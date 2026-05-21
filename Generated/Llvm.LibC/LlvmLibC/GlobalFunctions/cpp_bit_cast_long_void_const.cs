using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_long_void_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIlPKvEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS5_EE5valuesr3cpp21is_trivially_copyableIS5_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valueES5_E4typeERKS6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long) == sizeof (void const*) && cpp::is_trivially_constructible<long>::value && cpp::is_trivially_copyable<long>::value && cpp::is_trivially_copyable<void const*>::value, long>::type __llvm_libc_20_1_2_::cpp::bit_cast<long, void const*>(void const* const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long) == sizeof (void const*) && cpp::is_trivially_constructible<long>::value && cpp::is_trivially_copyable<long>::value && cpp::is_trivially_copyable<void const*>::value, long>::type")]
	public unsafe static long Invoke([NativeType("void const* const&")] void* from)
	{
		return *unchecked((long*)from);
	}
}
