using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_max_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIgEERKT_S4_S4_")]
	[DemangledName("__float128 const& __llvm_libc_20_1_2_::cpp::max<__float128>(__float128 const&, __float128 const&)")]
	[return: NativeType("__float128 const&")]
	public unsafe static void* Invoke([MangledName("a")][NativeType("__float128 const&")] void* A, [MangledName("b")][NativeType("__float128 const&")] void* B)
	{
		return (!unchecked(*(double*)A < *(double*)B)) ? A : B;
	}
}
