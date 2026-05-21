using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_unsigned_Fract_unsigned_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRjDRjEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned _Fract) == sizeof (unsigned _Fract) && cpp::is_trivially_constructible<unsigned _Fract>::value && cpp::is_trivially_copyable<unsigned _Fract>::value && cpp::is_trivially_copyable<unsigned _Fract>::value, unsigned _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned _Fract, unsigned _Fract>(unsigned _Fract const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned _Fract) == sizeof (unsigned _Fract) && cpp::is_trivially_constructible<unsigned _Fract>::value && cpp::is_trivially_copyable<unsigned _Fract>::value && cpp::is_trivially_copyable<unsigned _Fract>::value, unsigned _Fract>::type")]
	public unsafe static short Invoke([MangledName("from")][NativeType("unsigned _Fract const&")] void* From)
	{
		return *unchecked((short*)From);
	}
}
