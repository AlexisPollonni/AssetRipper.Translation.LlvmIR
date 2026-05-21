using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Cpp_min_int
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3minIiEERKT_S4_S4_")]
	[DemangledName("int const& __llvm_libc_20_1_2_::cpp::min<int>(int const&, int const&)")]
	[return: NativeType("int const&")]
	public unsafe static void* Invoke([MangledName("a")][NativeType("int const&")] void* A, [MangledName("b")][NativeType("int const&")] void* B)
	{
		return unchecked(*(int*)A >= *(int*)B) ? B : A;
	}
}
