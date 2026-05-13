using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal10quick_sortINS0_14ArrayFixedSizeILm4EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRT_RKT0_")]
[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>&, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class void_internal_quick_sort_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static void Invoke(void* array, void* is_less)
	{
		void* ancestor_pivot = null;
		long limit = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &ancestor_pivot);
		ancestor_pivot = null;
		llvm_lifetime_start_p0.Invoke(8L, &limit);
		limit = unchecked(2L * internal_ilog2_unsigned_long.Invoke(internal_ArrayFixedSize_4ul_len_const.Invoke(array) | 1L));
		void_internal_quick_sort_impl_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, ancestor_pivot, limit, is_less);
		llvm_lifetime_end_p0.Invoke(8L, &limit);
		llvm_lifetime_end_p0.Invoke(8L, &ancestor_pivot);
	}
}
