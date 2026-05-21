using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_cpp_array_unsigned_long_2ul_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castINS0_5arrayImLm2EEEoEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS5_EE5valuesr3cpp21is_trivially_copyableIS5_EE5valuesr3cpp21is_trivially_copyableIS6_EE5valueES5_E4typeERKS6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>) == sizeof (unsigned __int128) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>::value && cpp::is_trivially_copyable<unsigned __int128>::value, __llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>::type __llvm_libc_20_1_2_::cpp::bit_cast<__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>, unsigned __int128>(unsigned __int128 const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>) == sizeof (unsigned __int128) && cpp::is_trivially_constructible<__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>::value && cpp::is_trivially_copyable<__llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>::value && cpp::is_trivially_copyable<unsigned __int128>::value, __llvm_libc_20_1_2_::cpp::array<unsigned long, 2ul>>::type")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("from")][NativeType("unsigned __int128 const&")] void* From)
	{
		Llvm_libc_20_1_2_cpp_array_i3937k llvm_libc_20_1_2_cpp_array_i3937k = default(Llvm_libc_20_1_2_cpp_array_i3937k);
		Llvm_memcpy_p0_p0_i64.Invoke(&llvm_libc_20_1_2_cpp_array_i3937k, From, 16L, isVolatile: false);
		return *unchecked((Struct_fiz2nb*)(&llvm_libc_20_1_2_cpp_array_i3937k.Data));
	}
}
