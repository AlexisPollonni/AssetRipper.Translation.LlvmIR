using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_s5t5wp
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_8internal9heap_sortINS0_14ArrayFixedSizeILm16EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRKT_RKT0_ENKUlmE_clEm")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::heap_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul> const&, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(unsigned long)::operator()(unsigned long) const")]
	[CleanName("lambda_Invoke")]
	[return: NativeType("void")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned long")] long i)
	{
		return unchecked(2L * i + 1L);
	}
}
