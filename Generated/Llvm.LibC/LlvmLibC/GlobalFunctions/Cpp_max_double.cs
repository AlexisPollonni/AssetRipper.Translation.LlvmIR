using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_max_double
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIdEERKT_S4_S4_")]
	[DemangledName("double const& __llvm_libc_20_1_2_::cpp::max<double>(double const&, double const&)")]
	[return: NativeType("double const&")]
	public unsafe static void* Invoke([MangledName("a")][NativeType("double const&")] void* A, [MangledName("b")][NativeType("double const&")] void* B)
	{
		return (!unchecked(*(double*)A < *(double*)B)) ? A : B;
	}
}
