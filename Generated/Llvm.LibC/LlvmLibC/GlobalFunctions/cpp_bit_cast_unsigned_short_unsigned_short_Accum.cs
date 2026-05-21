using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_unsigned_short_unsigned_short_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castItDAtEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned short) == sizeof (unsigned short _Accum) && cpp::is_trivially_constructible<unsigned short>::value && cpp::is_trivially_copyable<unsigned short>::value && cpp::is_trivially_copyable<unsigned short _Accum>::value, unsigned short>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned short, unsigned short _Accum>(unsigned short _Accum const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned short) == sizeof (unsigned short _Accum) && cpp::is_trivially_constructible<unsigned short>::value && cpp::is_trivially_copyable<unsigned short>::value && cpp::is_trivially_copyable<unsigned short _Accum>::value, unsigned short>::type")]
	public unsafe static short Invoke([NativeType("unsigned short _Accum const&")] void* from)
	{
		return *unchecked((short*)from);
	}
}
