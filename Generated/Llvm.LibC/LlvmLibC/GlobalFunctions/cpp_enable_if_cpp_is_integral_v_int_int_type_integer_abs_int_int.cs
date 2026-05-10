using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L11integer_absIiEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EES3_E4typeES3_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<int>, int>::type __llvm_libc_20_1_2_::integer_abs<int>(int)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_int_int_type_integer_abs_int_int
{
	public static int Invoke(int n)
	{
		return (n >= 0) ? n : (-n);
	}
}
