using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_first_leading_one_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_17first_leading_oneIjEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::first_leading_one<unsigned int>(unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned int")] int Value)
	{
		return Llvm_libc_20_1_2_first_leading_zero_unsigned_int.Invoke(Value ^ -1);
	}
}
