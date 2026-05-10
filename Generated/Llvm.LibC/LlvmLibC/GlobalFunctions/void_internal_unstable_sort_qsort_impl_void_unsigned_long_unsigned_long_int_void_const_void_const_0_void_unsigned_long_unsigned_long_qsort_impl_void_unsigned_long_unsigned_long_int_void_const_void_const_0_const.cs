using LlvmLibC.Helpers;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal13unstable_sortIZNS_14__qsort_impl__EPvmmPFiPKvS4_EE3$_0EEvS2_mmRKT_")]
[DemangledName("void __llvm_libc_20_1_2_::internal::unstable_sort<__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(void*, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
internal static partial class void_internal_unstable_sort_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_void_unsigned_long_unsigned_long_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const
{
	public unsafe static void Invoke(void* array, long array_len, long elem_size, void* is_less)
	{
		void_internal_unstable_sort_impl_true_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_void_unsigned_long_unsigned_long_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const.Invoke(array, array_len, elem_size, is_less);
	}
}
