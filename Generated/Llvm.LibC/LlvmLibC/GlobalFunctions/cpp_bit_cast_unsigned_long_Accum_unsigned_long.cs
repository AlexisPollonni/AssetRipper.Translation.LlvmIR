using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_unsigned_long_Accum_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDAmmEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned long _Accum) == sizeof (unsigned long) && cpp::is_trivially_constructible<unsigned long _Accum>::value && cpp::is_trivially_copyable<unsigned long _Accum>::value && cpp::is_trivially_copyable<unsigned long>::value, unsigned long _Accum>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned long _Accum, unsigned long>(unsigned long const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned long _Accum) == sizeof (unsigned long) && cpp::is_trivially_constructible<unsigned long _Accum>::value && cpp::is_trivially_copyable<unsigned long _Accum>::value && cpp::is_trivially_copyable<unsigned long>::value, unsigned long _Accum>::type")]
	public unsafe static long Invoke([NativeType("unsigned long const&")] void* from)
	{
		return *unchecked((long*)from);
	}
}
