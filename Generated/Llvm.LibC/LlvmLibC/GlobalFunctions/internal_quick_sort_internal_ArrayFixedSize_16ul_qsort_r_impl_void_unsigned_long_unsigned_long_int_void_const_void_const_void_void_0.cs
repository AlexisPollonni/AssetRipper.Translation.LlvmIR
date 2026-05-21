using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_quick_sort_internal_ArrayFixedSize_16ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal10quick_sortINS0_14ArrayFixedSizeILm16EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRT_RKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>&, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>&")] void* array, [NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* is_less)
	{
		void* ancestor_pivot = null;
		long limit = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &ancestor_pivot);
		ancestor_pivot = null;
		llvm_lifetime_start_p0.Invoke(8L, &limit);
		limit = unchecked(2L * internal_ilog2.Invoke(ArrayFixedSize_16ul_len.Invoke(array) | 1L));
		internal_quick_sort_impl_internal_ArrayFixedSize_16ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(array, ancestor_pivot, limit, is_less);
		llvm_lifetime_end_p0.Invoke(8L, &limit);
		llvm_lifetime_end_p0.Invoke(8L, &ancestor_pivot);
	}
}
