using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_bit_cast_long_Fract_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8bit_castIDRliEENS0_9enable_ifIXaaaaaaeqstT_stT0_sr3cpp26is_trivially_constructibleIS3_EE5valuesr3cpp21is_trivially_copyableIS3_EE5valuesr3cpp21is_trivially_copyableIS4_EE5valueES3_E4typeERKS4_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long _Fract) == sizeof (int) && cpp::is_trivially_constructible<long _Fract>::value && cpp::is_trivially_copyable<long _Fract>::value && cpp::is_trivially_copyable<int>::value, long _Fract>::type __llvm_libc_20_1_2_::cpp::bit_cast<long _Fract, int>(int const&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<sizeof (long _Fract) == sizeof (int) && cpp::is_trivially_constructible<long _Fract>::value && cpp::is_trivially_copyable<long _Fract>::value && cpp::is_trivially_copyable<int>::value, long _Fract>::type")]
	public unsafe static int Invoke([NativeType("int const&")] void* from)
	{
		return *unchecked((int*)from);
	}
}
