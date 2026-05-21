using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_Accum_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDAijEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Accum) == sizeof (unsigned int) && cpp::is_trivially_constructible<_Accum>::value && cpp::is_trivially_copyable<_Accum>::value && cpp::is_trivially_copyable<unsigned int>::value, _Accum>::type __llvm_libc_20_1_2_::cpp::bit_cast<_Accum, unsigned int>(unsigned int const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (_Accum) == sizeof (unsigned int) && cpp::is_trivially_constructible<_Accum>::value && cpp::is_trivially_copyable<_Accum>::value && cpp::is_trivially_copyable<unsigned int>::value, _Accum>::type")]
	public unsafe static int Invoke([MangledName("from")][NativeType("unsigned int const&")] void* From)
	{
		return *unchecked((int*)From);
	}
}
