using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3minIiEERKT_S4_S4_")]
[DemangledName("int const& __llvm_libc_20_1_2_::cpp::min<int>(int const&, int const&)")]
internal static partial class int_const_cpp_min_int_int_const_int_const
{
	public unsafe static void* Invoke(void* a, void* b)
	{
		return unchecked(*(int*)a >= *(int*)b) ? b : a;
	}
}
