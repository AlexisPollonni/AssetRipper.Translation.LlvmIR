using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class integer_rem_quo_long_69v27w
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L15integer_rem_quoIlEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EEvE4typeES3_S3_RS3_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long>, void>::type __llvm_libc_20_1_2_::integer_rem_quo<long>(long, long, long&, long&)")]
	[CleanName("integer_rem_quo_long")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long>, void>::type")]
	public unsafe static void Invoke([NativeType("long")] long x, [NativeType("long")] long y, [NativeType("long&")] void* quot, [NativeType("long&")] void* rem)
	{
		unchecked
		{
			*(long*)quot = x / y;
			*(long*)rem = x % y;
		}
	}
}
