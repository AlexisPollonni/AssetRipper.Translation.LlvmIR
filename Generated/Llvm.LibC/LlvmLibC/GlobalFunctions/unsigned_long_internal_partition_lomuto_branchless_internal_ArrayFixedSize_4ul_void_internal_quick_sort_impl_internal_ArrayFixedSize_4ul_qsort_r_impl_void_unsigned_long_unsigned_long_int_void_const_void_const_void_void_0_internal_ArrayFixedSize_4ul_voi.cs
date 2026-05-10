using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal27partition_lomuto_branchlessINS0_14ArrayFixedSizeILm4EEEZNS0_15quick_sort_implIS3_ZNS_16__qsort_r_impl__EPvmmPFiPKvS7_S5_ES5_E3$_0EEvRT_S7_mRKT0_EUlS7_S7_E_EEmRKSB_S7_SF_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition_lomuto_branchless<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(void const*, void const*)>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul> const&, void const*, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class unsigned_long_internal_partition_lomuto_branchless_internal_ArrayFixedSize_4ul_void_internal_quick_sort_impl_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_internal_ArrayFixedSize_4ul_const_void_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static long Invoke(void* array, void* pivot, void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_ArrayFixedSize_4ul_len_const.Invoke(array);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 0L;
		unchecked
		{
			while ((ulong)num3 < (ulong)num)
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (void_internal_quick_sort_impl_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_operator_void_const_void_const_const.Invoke(is_less, internal_ArrayFixedSize_4ul_get_unsigned_long_const.Invoke(array, num3), pivot) ? ((sbyte)1) : ((sbyte)0));
				internal_ArrayFixedSize_4ul_swap_unsigned_long_unsigned_long_const.Invoke(array, num2, num3);
				num2 += (((b & 1) == 1) ? 1L : 0L);
				num3++;
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			long result = num2;
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
