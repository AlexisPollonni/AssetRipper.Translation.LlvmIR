using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_Fract_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRisEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Fract) == sizeof (short) && cpp::is_trivially_constructible<_Fract>::value && cpp::is_trivially_copyable<_Fract>::value && cpp::is_trivially_copyable<short>::value, _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<_Fract, short>(short const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Fract) == sizeof (short) && cpp::is_trivially_constructible<_Fract>::value && cpp::is_trivially_copyable<_Fract>::value && cpp::is_trivially_copyable<short>::value, _Fract>::type")]
	public unsafe static short Invoke([MangledName("from")][NativeType("short const&")] void* From)
	{
		return *unchecked((short*)From);
	}
}
