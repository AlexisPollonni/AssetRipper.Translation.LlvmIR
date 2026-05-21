using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_float128_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIgoEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__float128) == sizeof (unsigned __int128) && cpp::is_trivially_constructible<__float128>::value && cpp::is_trivially_copyable<__float128>::value && cpp::is_trivially_copyable<unsigned __int128>::value, __float128>::type __llvm_libc_20_1_2_::cpp::bit_cast<__float128, unsigned __int128>(unsigned __int128 const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__float128) == sizeof (unsigned __int128) && cpp::is_trivially_constructible<__float128>::value && cpp::is_trivially_copyable<__float128>::value && cpp::is_trivially_copyable<unsigned __int128>::value, __float128>::type")]
	public unsafe static double Invoke([MangledName("from")][NativeType("unsigned __int128 const&")] void* From)
	{
		return *unchecked((double*)From);
	}
}
