using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_unsigned_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castImlEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned long) == sizeof (long) && cpp::is_trivially_constructible<unsigned long>::value && cpp::is_trivially_copyable<unsigned long>::value && cpp::is_trivially_copyable<long>::value, unsigned long>::type __llvm_libc_20_1_2_::cpp::bit_cast<unsigned long, long>(long const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (unsigned long) == sizeof (long) && cpp::is_trivially_constructible<unsigned long>::value && cpp::is_trivially_copyable<unsigned long>::value && cpp::is_trivially_copyable<long>::value, unsigned long>::type")]
	public unsafe static long Invoke([MangledName("from")][NativeType("long const&")] void* From)
	{
		return *unchecked((long*)From);
	}
}
