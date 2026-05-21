using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_unsigned_Accum_unsigned_long_Fract
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDAjDRmEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned _Accum) == sizeof (unsigned long _Fract) && cpp::is_trivially_constructible<unsigned _Accum>::value && cpp::is_trivially_copyable<unsigned _Accum>::value && cpp::is_trivially_copyable<unsigned long _Fract>::value, unsigned _Accum>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned _Accum, unsigned long _Fract>(unsigned long _Fract const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned _Accum) == sizeof (unsigned long _Fract) && cpp::is_trivially_constructible<unsigned _Accum>::value && cpp::is_trivially_copyable<unsigned _Accum>::value && cpp::is_trivially_copyable<unsigned long _Fract>::value, unsigned _Accum>::type")]
	public unsafe static int Invoke([NativeType("unsigned long _Fract const&")] void* from)
	{
		return *unchecked((int*)from);
	}
}
