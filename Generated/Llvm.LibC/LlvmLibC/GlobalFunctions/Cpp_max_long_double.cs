using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_max_long_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIeEERKT_S4_S4_")]
	[DemangledName("long double const& __llvm_libc_20_1_2_::cpp::max<long double>(long double const&, long double const&)")]
	[return: NativeType("long double const&")]
	public unsafe static void* Invoke([MangledName("a")][NativeType("long double const&")] void* A, [MangledName("b")][NativeType("long double const&")] void* B)
	{
		return (!unchecked(*(double*)A < *(double*)B)) ? A : B;
	}
}
