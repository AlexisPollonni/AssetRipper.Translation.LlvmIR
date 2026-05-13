using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_L15integer_rem_quoIxEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EEvE4typeES3_S3_RS3_S6_")]
[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long long>, void>::type __llvm_libc_20_1_2_::integer_rem_quo<long long>(long long, long long, long long&, long long&)")]
internal static partial class cpp_enable_if_cpp_is_integral_v_long_long_void_type_integer_rem_quo_long_long_long_long_long_long_long_long_long_long
{
	public unsafe static void Invoke(long x, long y, void* quot, void* rem)
	{
		unchecked
		{
			*(long*)quot = x / y;
			*(long*)rem = x % y;
		}
	}
}
