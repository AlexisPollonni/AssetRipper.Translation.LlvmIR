using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_short_Accum_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDAssEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (short _Accum) == sizeof (short) && cpp::is_trivially_constructible<short _Accum>::value && cpp::is_trivially_copyable<short _Accum>::value && cpp::is_trivially_copyable<short>::value, short _Accum>::type __llvm_libc_20_1_2_::cpp::bit_cast<short _Accum, short>(short const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (short _Accum) == sizeof (short) && cpp::is_trivially_constructible<short _Accum>::value && cpp::is_trivially_copyable<short _Accum>::value && cpp::is_trivially_copyable<short>::value, short _Accum>::type")]
	public unsafe static short Invoke([NativeType("short const&")] void* from)
	{
		return *unchecked((short*)from);
	}
}
