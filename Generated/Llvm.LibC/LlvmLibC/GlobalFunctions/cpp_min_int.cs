using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class cpp_min_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3minIiEERKT_S4_S4_")]
	[DemangledName("int const& __llvm_libc_20_1_2_::cpp::min<int>(int const&, int const&)")]
	[return: NativeType("int const&")]
	public unsafe static void* Invoke([NativeType("int const&")] void* a, [NativeType("int const&")] void* b)
	{
		return unchecked(*(int*)a >= *(int*)b) ? b : a;
	}
}
