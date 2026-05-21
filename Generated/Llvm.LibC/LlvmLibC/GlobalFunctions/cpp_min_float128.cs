using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_min_float128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3minIgEERKT_S4_S4_")]
	[DemangledName("__float128 const& __llvm_libc_20_1_2_::cpp::min<__float128>(__float128 const&, __float128 const&)")]
	[return: NativeType("__float128 const&")]
	public unsafe static void* Invoke([NativeType("__float128 const&")] void* a, [NativeType("__float128 const&")] void* b)
	{
		return (!unchecked(*(double*)a < *(double*)b)) ? b : a;
	}
}
