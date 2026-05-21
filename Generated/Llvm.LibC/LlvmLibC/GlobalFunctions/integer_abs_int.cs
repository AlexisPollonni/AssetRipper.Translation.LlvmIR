using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class integer_abs_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L11integer_absIiEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EES3_E4typeES3_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<int>, int>::type __llvm_libc_20_1_2_::integer_abs<int>(int)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<int>, int>::type")]
	public static int Invoke([NativeType("int")] int n)
	{
		return (n >= 0) ? n : (-n);
	}
}
