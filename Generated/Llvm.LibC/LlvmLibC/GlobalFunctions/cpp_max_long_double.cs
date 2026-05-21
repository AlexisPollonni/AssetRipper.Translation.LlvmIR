using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_max_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIeEERKT_S4_S4_")]
	[DemangledName("long double const& __llvm_libc_20_1_2_::cpp::max<long double>(long double const&, long double const&)")]
	[return: NativeType("long double const&")]
	public unsafe static void* Invoke([NativeType("long double const&")] void* a, [NativeType("long double const&")] void* b)
	{
		return (!unchecked(*(double*)a < *(double*)b)) ? a : b;
	}
}
