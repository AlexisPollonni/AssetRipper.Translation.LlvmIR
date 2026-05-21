using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_first_trailing_one_unsigned_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_18first_trailing_oneIjEENS_3cpp9enable_ifIXsr3cppE13is_unsigned_vIT_EEiE4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type __llvm_libc_20_1_2_::first_trailing_one<unsigned int>(unsigned int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_unsigned_v<unsigned int>, int>::type")]
	public static int Invoke([MangledName("value")][NativeType("unsigned int")] int Value)
	{
		return (Value != Integer_impl_unsigned_int_0u_4294967295u_max.Invoke()) ? (Cpp_countr_zero_unsigned_int.Invoke(Value) + 1) : 0;
	}
}
