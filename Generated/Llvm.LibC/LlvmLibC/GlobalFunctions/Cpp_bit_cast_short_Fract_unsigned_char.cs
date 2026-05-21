using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_short_Fract_unsigned_char
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRshEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (short _Fract) == sizeof (unsigned char) && cpp::is_trivially_constructible<short _Fract>::value && cpp::is_trivially_copyable<short _Fract>::value && cpp::is_trivially_copyable<unsigned char>::value, short _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<short _Fract, unsigned char>(unsigned char const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (short _Fract) == sizeof (unsigned char) && cpp::is_trivially_constructible<short _Fract>::value && cpp::is_trivially_copyable<short _Fract>::value && cpp::is_trivially_copyable<unsigned char>::value, short _Fract>::type")]
	public unsafe static sbyte Invoke([MangledName("from")][NativeType("unsigned char const&")] void* From)
	{
		return *unchecked((sbyte*)From);
	}
}
