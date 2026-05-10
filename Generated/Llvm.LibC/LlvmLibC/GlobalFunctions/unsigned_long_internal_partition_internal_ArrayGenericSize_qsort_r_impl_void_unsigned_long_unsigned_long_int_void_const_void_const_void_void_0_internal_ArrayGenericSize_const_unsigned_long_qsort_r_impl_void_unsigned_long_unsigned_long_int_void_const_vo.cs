using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal9partitionINS0_16ArrayGenericSizeEZNS_16__qsort_r_impl__EPvmmPFiPKvS5_S3_ES3_E3$_0EEmRKT_mRKT0_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class unsigned_long_internal_partition_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static long Invoke(void* array, long pivot_index, void* is_less)
	{
		scanf_core_ReadBuffer scanf_core_ReadBuffer2 = default(scanf_core_ReadBuffer);
		void* pivot = null;
		long num = 0L;
		if (pivot_index != 0L)
		{
			internal_ArrayGenericSize_swap_unsigned_long_unsigned_long_const.Invoke(array, 0L, pivot_index);
		}
		llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer2);
		unchecked
		{
			*(IntPtr*)(&scanf_core_ReadBuffer2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&scanf_core_ReadBuffer2))[1] = -6148914691236517206L;
			((long*)(&scanf_core_ReadBuffer2))[2] = -6148914691236517206L;
			internal_ArrayGenericSize_make_array_unsigned_long_unsigned_long_const.Invoke(&scanf_core_ReadBuffer2, array, 1L, internal_ArrayGenericSize_len_const.Invoke(array) - 1L);
			llvm_lifetime_start_p0.Invoke(8L, &pivot);
			pivot = internal_ArrayGenericSize_get_unsigned_long_const.Invoke(array, 0L);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = -6148914691236517206L;
			num = unsigned_long_internal_partition_hoare_branchy_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_const_void_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(&scanf_core_ReadBuffer2, pivot, is_less);
			internal_ArrayGenericSize_swap_unsigned_long_unsigned_long_const.Invoke(array, 0L, num);
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &pivot);
			llvm_lifetime_end_p0.Invoke(24L, &scanf_core_ReadBuffer2);
			return result;
		}
	}
}
