using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_double_unsigned_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIdmEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) == sizeof (unsigned long) && cpp::is_trivially_constructible<double>::value && cpp::is_trivially_copyable<double>::value && cpp::is_trivially_copyable<unsigned long>::value, double>::type __llvm_libc_20_1_2_::cpp::bit_cast<double, unsigned long>(unsigned long const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (double) == sizeof (unsigned long) && cpp::is_trivially_constructible<double>::value && cpp::is_trivially_copyable<double>::value && cpp::is_trivially_copyable<unsigned long>::value, double>::type")]
	public unsafe static double Invoke([MangledName("from")][NativeType("unsigned long const&")] void* From)
	{
		return *unchecked((double*)From);
	}
}
