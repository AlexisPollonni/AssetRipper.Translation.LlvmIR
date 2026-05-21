using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_bit_cast_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIldEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long) == sizeof (double) && cpp::is_trivially_constructible<long>::value && cpp::is_trivially_copyable<long>::value && cpp::is_trivially_copyable<double>::value, long>::type __llvm_libc_20_1_2_::cpp::bit_cast<long, double>(double const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long) == sizeof (double) && cpp::is_trivially_constructible<long>::value && cpp::is_trivially_copyable<long>::value && cpp::is_trivially_copyable<double>::value, long>::type")]
	public unsafe static long Invoke([MangledName("from")][NativeType("double const&")] void* From)
	{
		return *unchecked((long*)From);
	}
}
