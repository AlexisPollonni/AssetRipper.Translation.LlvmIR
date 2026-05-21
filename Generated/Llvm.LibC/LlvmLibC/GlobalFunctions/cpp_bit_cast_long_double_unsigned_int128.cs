using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_long_double_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIeoEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long double) == sizeof (unsigned __int128) && cpp::is_trivially_constructible<long double>::value && cpp::is_trivially_copyable<long double>::value && cpp::is_trivially_copyable<unsigned __int128>::value, long double>::type __llvm_libc_20_1_2_::cpp::bit_cast<long double, unsigned __int128>(unsigned __int128 const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long double) == sizeof (unsigned __int128) && cpp::is_trivially_constructible<long double>::value && cpp::is_trivially_copyable<long double>::value && cpp::is_trivially_copyable<unsigned __int128>::value, long double>::type")]
	public unsafe static double Invoke([NativeType("unsigned __int128 const&")] void* from)
	{
		return *unchecked((double*)from);
	}
}
