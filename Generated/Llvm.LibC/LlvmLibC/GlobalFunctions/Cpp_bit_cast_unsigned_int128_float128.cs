using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_unsigned_int128_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIogEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned __int128) == sizeof (__float128) && cpp::is_trivially_constructible<unsigned __int128>::value && cpp::is_trivially_copyable<unsigned __int128>::value && cpp::is_trivially_copyable<__float128>::value, unsigned __int128>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned __int128, __float128>(__float128 const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned __int128) == sizeof (__float128) && cpp::is_trivially_constructible<unsigned __int128>::value && cpp::is_trivially_copyable<unsigned __int128>::value && cpp::is_trivially_copyable<__float128>::value, unsigned __int128>::type")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("from")][NativeType("__float128 const&")] void* From)
	{
		unchecked
		{
			Int128 @int = *(Int128*)From;
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
