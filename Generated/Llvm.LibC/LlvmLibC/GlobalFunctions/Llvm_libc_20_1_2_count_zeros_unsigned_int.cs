using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_count_zeros_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11count_zerosIjEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::count_zeros<unsigned int>(unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned int")] int Value)
	{
		return Cpp_popcount_unsigned_int.Invoke(Value ^ -1);
	}
}
