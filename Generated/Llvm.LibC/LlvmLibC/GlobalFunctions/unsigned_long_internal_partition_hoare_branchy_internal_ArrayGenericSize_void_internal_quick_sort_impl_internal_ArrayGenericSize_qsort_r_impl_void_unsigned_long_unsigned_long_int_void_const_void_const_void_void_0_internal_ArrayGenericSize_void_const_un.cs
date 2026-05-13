using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal23partition_hoare_branchyINS0_16ArrayGenericSizeEZNS0_15quick_sort_implIS2_ZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRT_S6_mRKT0_EUlS6_S6_E_EEmRKSA_S6_SE_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition_hoare_branchy<__llvm_libc_20_1_2_::internal::ArrayGenericSize, void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(void const*, void const*)>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, void const*, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class unsigned_long_internal_partition_hoare_branchy_internal_ArrayGenericSize_void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_internal_ArrayGenericSize_const_void_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static long Invoke(void* array, void* pivot, void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_ArrayGenericSize_len_const.Invoke(array);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = num;
		unchecked
		{
			while (true)
			{
				if ((ulong)num2 < (ulong)num3 && void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_operator_void_const_void_const_const.Invoke(is_less, internal_ArrayGenericSize_get_unsigned_long_const.Invoke(array, num2), pivot))
				{
					num2++;
					continue;
				}
				do
				{
					num3 += -1L;
				}
				while ((ulong)num2 < (ulong)num3 && !void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_operator_void_const_void_const_const.Invoke(is_less, internal_ArrayGenericSize_get_unsigned_long_const.Invoke(array, num3), pivot));
				if ((ulong)num2 >= (ulong)num3)
				{
					break;
				}
				internal_ArrayGenericSize_swap_unsigned_long_unsigned_long_const.Invoke(array, num2, num3);
				num2++;
			}
			long result = num2;
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
