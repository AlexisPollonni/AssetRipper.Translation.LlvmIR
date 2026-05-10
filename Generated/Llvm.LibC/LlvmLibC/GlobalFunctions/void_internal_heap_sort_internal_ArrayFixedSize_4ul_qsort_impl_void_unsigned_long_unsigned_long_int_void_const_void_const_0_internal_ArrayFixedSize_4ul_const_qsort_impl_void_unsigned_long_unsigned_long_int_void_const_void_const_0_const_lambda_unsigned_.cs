using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_8internal9heap_sortINS0_14ArrayFixedSizeILm4EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEvRKT_RKT0_ENKUlmE_clEm")]
[DemangledName("void __llvm_libc_20_1_2_::internal::heap_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul> const&, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)::'lambda'(unsigned long)::operator()(unsigned long) const")]
internal static partial class void_internal_heap_sort_internal_ArrayFixedSize_4ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_internal_ArrayFixedSize_4ul_const_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const_lambda_unsigned_long_operator_unsigned_long_const
{
	public unsafe static long Invoke(void* @this, long i)
	{
		return unchecked(2L * i + 1L);
	}
}
