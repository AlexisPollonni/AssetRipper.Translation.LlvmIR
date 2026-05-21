using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class integer_rem_quo_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L15integer_rem_quoIiEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EEvE4typeES3_S3_RS3_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<int>, void>::type __llvm_libc_20_1_2_::integer_rem_quo<int>(int, int, int&, int&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<int>, void>::type")]
	public unsafe static void Invoke([NativeType("int")] int x, [NativeType("int")] int y, [NativeType("int&")] void* quot, [NativeType("int&")] void* rem)
	{
		unchecked
		{
			*(int*)quot = x / y;
			*(int*)rem = x % y;
		}
	}
}
