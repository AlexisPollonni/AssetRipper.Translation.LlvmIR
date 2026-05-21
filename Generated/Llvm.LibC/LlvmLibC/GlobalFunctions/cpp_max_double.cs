using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_max_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIdEERKT_S4_S4_")]
	[DemangledName("double const& __llvm_libc_20_1_2_::cpp::max<double>(double const&, double const&)")]
	[return: NativeType("double const&")]
	public unsafe static void* Invoke([NativeType("double const&")] void* a, [NativeType("double const&")] void* b)
	{
		return (!unchecked(*(double*)a < *(double*)b)) ? a : b;
	}
}
