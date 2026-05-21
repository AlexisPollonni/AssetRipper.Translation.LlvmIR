using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_unsigned_int_unsigned_Accum
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIjDAjEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned int) == sizeof (unsigned _Accum) && cpp::is_trivially_constructible<unsigned int>::value && cpp::is_trivially_copyable<unsigned int>::value && cpp::is_trivially_copyable<unsigned _Accum>::value, unsigned int>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned int, unsigned _Accum>(unsigned _Accum const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned int) == sizeof (unsigned _Accum) && cpp::is_trivially_constructible<unsigned int>::value && cpp::is_trivially_copyable<unsigned int>::value && cpp::is_trivially_copyable<unsigned _Accum>::value, unsigned int>::type")]
	public unsafe static int Invoke([MangledName("from")][NativeType("unsigned _Accum const&")] void* From)
	{
		return *unchecked((int*)From);
	}
}
