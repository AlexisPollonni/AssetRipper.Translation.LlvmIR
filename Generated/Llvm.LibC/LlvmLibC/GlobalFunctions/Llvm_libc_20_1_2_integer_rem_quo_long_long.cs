using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_integer_rem_quo_long_long
{
	[MangledName("_ZN19__llvm_libc_20_1_2_L15integer_rem_quoIxEENS_3cpp9enable_ifIXsr3cppE13is_integral_vIT_EEvE4typeES3_S3_RS3_S6_")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long long>, void>::type __llvm_libc_20_1_2_::integer_rem_quo<long long>(long long, long long, long long&, long long&)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::enable_if<cpp::is_integral_v<long long>, void>::type")]
	public unsafe static void Invoke([MangledName("x")][NativeType("long long")] long X, [MangledName("y")][NativeType("long long")] long Y, [MangledName("quot")][NativeType("long long&")] void* Quot, [MangledName("rem")][NativeType("long long&")] void* Rem)
	{
		unchecked
		{
			*(long*)Quot = X / Y;
			*(long*)Rem = X % Y;
		}
	}
}
