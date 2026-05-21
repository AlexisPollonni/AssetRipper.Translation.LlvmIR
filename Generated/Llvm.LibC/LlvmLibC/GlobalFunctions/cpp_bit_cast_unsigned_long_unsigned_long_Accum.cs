using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_unsigned_long_unsigned_long_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castImDAmEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned long) == sizeof (unsigned long _Accum) && cpp::is_trivially_constructible<unsigned long>::value && cpp::is_trivially_copyable<unsigned long>::value && cpp::is_trivially_copyable<unsigned long _Accum>::value, unsigned long>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned long, unsigned long _Accum>(unsigned long _Accum const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned long) == sizeof (unsigned long _Accum) && cpp::is_trivially_constructible<unsigned long>::value && cpp::is_trivially_copyable<unsigned long>::value && cpp::is_trivially_copyable<unsigned long _Accum>::value, unsigned long>::type")]
	public unsafe static long Invoke([NativeType("unsigned long _Accum const&")] void* from)
	{
		return *unchecked((long*)from);
	}
}
