using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_unsigned_int128_cpp_array_unsigned_long_2ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIoNS0_5arrayImLm2EEEEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS5_EE5valuesr3cpp21is_trivially_copyableIS5_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valueES5_E4typeERKS6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned __int128) == sizeof (__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>) && cpp::is_trivially_constructible<unsigned __int128>::value && cpp::is_trivially_copyable<unsigned __int128>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>::value, unsigned __int128>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned __int128, __llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>(__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned __int128) == sizeof (__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>) && cpp::is_trivially_constructible<unsigned __int128>::value && cpp::is_trivially_copyable<unsigned __int128>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>::value, unsigned __int128>::type")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("from")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul> const&")] Llvm_libc_20_1_2_cpp_array_i3937k* From)
	{
		unchecked
		{
			Int128 @int = *(Int128*)From;
			return *(Struct_fiz2nb*)(&@int);
		}
	}
}
