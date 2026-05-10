using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L15integer_rem_quoIiEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EEvE4typeES3_S3_RS3_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<int>, void>::type __llvm_libc_20_1_2_::integer_rem_quo<int>(int, int, int&, int&)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_int_void_type_integer_rem_quo_int_int_int_int_int
{
	public unsafe static void Invoke(int x, int y, void* quot, void* rem)
	{
		unchecked
		{
			*(int*)quot = x / y;
			*(int*)rem = x % y;
		}
	}
}
