using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_unsigned_char_unsigned_short_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIhDRtEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned char) == sizeof (unsigned short _Fract) && cpp::is_trivially_constructible<unsigned char>::value && cpp::is_trivially_copyable<unsigned char>::value && cpp::is_trivially_copyable<unsigned short _Fract>::value, unsigned char>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned char, unsigned short _Fract>(unsigned short _Fract const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned char) == sizeof (unsigned short _Fract) && cpp::is_trivially_constructible<unsigned char>::value && cpp::is_trivially_copyable<unsigned char>::value && cpp::is_trivially_copyable<unsigned short _Fract>::value, unsigned char>::type")]
	public unsafe static sbyte Invoke([NativeType("unsigned short _Fract const&")] void* from)
	{
		return *unchecked((sbyte*)from);
	}
}
