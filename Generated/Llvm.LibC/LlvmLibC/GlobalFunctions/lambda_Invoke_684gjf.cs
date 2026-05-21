using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_684gjf
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_8internal9heap_sortINS0_16ArrayGenericSizeEZNS_14__qsort_impl__EPvmmPFiPKvS5_EE3$_0EEvRKT_RKT0_ENKUlmE_clEm")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::heap_sort<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)::'lambda'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("lambda_Invoke")]
	[return: NativeType("void")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned long")] long i)
	{
		return unchecked(2L * i + 1L);
	}
}
