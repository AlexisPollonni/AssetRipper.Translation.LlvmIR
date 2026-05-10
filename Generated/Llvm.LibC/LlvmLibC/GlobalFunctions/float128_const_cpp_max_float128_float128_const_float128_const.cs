using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp3maxIgEERKT_S4_S4_")]
[DemangledName("__float128 const& __llvm_libc_20_1_2_::cpp::max<__float128>(__float128 const&, __float128 const&)")]
internal static partial class float128_const_cpp_max_float128_float128_const_float128_const
{
	public unsafe static void* Invoke(void* a, void* b)
	{
		return (!unchecked(*(double*)a < *(double*)b)) ? a : b;
	}
}
