using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class First_trailing_one_unsigned_short
{
	[MangledName("_ZN19__llvm_libc_20_1_2_18first_trailing_oneItEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type __llvm_libc_20_1_2_::first_trailing_one<unsigned short>(unsigned short)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned short>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned short")] short Value)
	{
		short num = Value;
		return unchecked((ushort)num != (ushort)Integer_impl_unsigned_short_unsigned_short_0_unsigned_short_65535_max.Invoke()) ? (Cpp_countr_zero_unsigned_short.Invoke(num) + 1) : 0;
	}
}
