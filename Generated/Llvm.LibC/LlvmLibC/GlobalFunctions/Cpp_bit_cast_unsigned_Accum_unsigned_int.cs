using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_unsigned_Accum_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDAjjEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned _Accum) == sizeof (unsigned int) && cpp::is_trivially_constructible<unsigned _Accum>::value && cpp::is_trivially_copyable<unsigned _Accum>::value && cpp::is_trivially_copyable<unsigned int>::value, unsigned _Accum>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned _Accum, unsigned int>(unsigned int const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned _Accum) == sizeof (unsigned int) && cpp::is_trivially_constructible<unsigned _Accum>::value && cpp::is_trivially_copyable<unsigned _Accum>::value && cpp::is_trivially_copyable<unsigned int>::value, unsigned _Accum>::type")]
	public unsafe static int Invoke([MangledName("from")][NativeType("unsigned int const&")] void* From)
	{
		return *unchecked((int*)From);
	}
}
