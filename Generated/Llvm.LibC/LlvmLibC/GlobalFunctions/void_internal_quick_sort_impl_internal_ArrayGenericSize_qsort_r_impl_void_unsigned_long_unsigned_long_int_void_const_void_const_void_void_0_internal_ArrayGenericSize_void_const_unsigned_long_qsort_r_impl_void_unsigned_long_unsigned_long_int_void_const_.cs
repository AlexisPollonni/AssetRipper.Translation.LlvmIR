using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_16ArrayGenericSizeEZNS_16__qsort_r_impl__EPvmmPFiPKvS5_S3_ES3_E3$_0EEvRT_S5_mRKT0_")]
[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static void Invoke(void* array, void* ancestor_pivot, long limit, void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		anon_apfvhe anon_apfvhe2 = default(anon_apfvhe);
		long num4 = 0L;
		scanf_core_ReadBuffer scanf_core_ReadBuffer2 = default(scanf_core_ReadBuffer);
		void* ptr = null;
		long num5 = 0L;
		scanf_core_ReadBuffer scanf_core_ReadBuffer3 = default(scanf_core_ReadBuffer);
		void* ptr2 = ancestor_pivot;
		long num6 = limit;
		unchecked
		{
			while (true)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = internal_ArrayGenericSize_len_const.Invoke(array);
				int num7;
				if ((ulong)num <= 1uL)
				{
					num7 = 1;
				}
				else if (num6 == 0L)
				{
					void_internal_heap_sort_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, is_less);
					num7 = 1;
				}
				else
				{
					num6--;
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = unsigned_long_internal_choose_pivot_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, is_less);
					if (ptr2 != null && !qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_operator_void_const_void_const_const.Invoke(is_less, ptr2, internal_ArrayGenericSize_get_unsigned_long_const.Invoke(array, num2)))
					{
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						long pivot_index = num2;
						llvm_lifetime_start_p0.Invoke(16L, &anon_apfvhe2);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_apfvhe2.field_0, is_less, 16L, isVolatile: false);
						long num8 = unsigned_long_internal_partition_internal_ArrayGenericSize_void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_internal_ArrayGenericSize_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, pivot_index, &anon_apfvhe2);
						llvm_lifetime_end_p0.Invoke(16L, &anon_apfvhe2);
						num3 = num8;
						internal_ArrayGenericSize_reset_bounds_unsigned_long_unsigned_long.Invoke(array, num3 + 1L, internal_ArrayGenericSize_len_const.Invoke(array) - (num3 + 1L));
						ptr2 = null;
						num7 = 2;
						llvm_lifetime_end_p0.Invoke(8L, &num3);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = unsigned_long_internal_partition_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, num2, is_less);
						if (num == 2L)
						{
							num7 = 1;
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer2);
							*(IntPtr*)(&scanf_core_ReadBuffer2) = unchecked((nint)(-6148914691236517206L));
							((long*)(&scanf_core_ReadBuffer2))[1] = -6148914691236517206L;
							((long*)(&scanf_core_ReadBuffer2))[2] = -6148914691236517206L;
							internal_ArrayGenericSize_make_array_unsigned_long_unsigned_long_const.Invoke(&scanf_core_ReadBuffer2, array, 0L, num4);
							llvm_lifetime_start_p0.Invoke(8L, &ptr);
							ptr = internal_ArrayGenericSize_get_unsigned_long_const.Invoke(array, num4);
							llvm_lifetime_start_p0.Invoke(8L, &num5);
							num5 = num4 + 1L;
							llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer3);
							*(IntPtr*)(&scanf_core_ReadBuffer3) = unchecked((nint)(-6148914691236517206L));
							((long*)(&scanf_core_ReadBuffer3))[1] = -6148914691236517206L;
							((long*)(&scanf_core_ReadBuffer3))[2] = -6148914691236517206L;
							internal_ArrayGenericSize_make_array_unsigned_long_unsigned_long_const.Invoke(&scanf_core_ReadBuffer3, array, num5, internal_ArrayGenericSize_len_const.Invoke(array) - num5);
							Invoke(&scanf_core_ReadBuffer2, ptr2, num6, is_less);
							llvm_memcpy_p0_p0_i64.Invoke(array, &scanf_core_ReadBuffer3, 24L, isVolatile: false);
							ptr2 = ptr;
							llvm_lifetime_end_p0.Invoke(24L, &scanf_core_ReadBuffer3);
							llvm_lifetime_end_p0.Invoke(8L, &num5);
							llvm_lifetime_end_p0.Invoke(8L, &ptr);
							llvm_lifetime_end_p0.Invoke(24L, &scanf_core_ReadBuffer2);
							num7 = 0;
						}
						llvm_lifetime_end_p0.Invoke(8L, &num4);
					}
					llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
				llvm_lifetime_end_p0.Invoke(8L, &num);
				switch (num7)
				{
				case 0:
				case 2:
					continue;
				case 1:
					return;
				}
				throw new NotImplementedException("Reached LLVM unreachable instruction.");
			}
		}
	}
}
[MangledName("_ZZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_16ArrayGenericSizeEZNS_16__qsort_r_impl__EPvmmPFiPKvS5_S3_ES3_E3$_0EEvRT_S5_mRKT0_ENKUlS5_S5_E_clES5_S5_")]
[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(void const*, void const*)::operator()(void const*, void const*) const")]
internal static partial class void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_operator_void_const_void_const_const
{
	public unsafe static bool Invoke(void* @this, void* a, void* b)
	{
		return unchecked((byte)((qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_operator_void_const_void_const_const.Invoke(&((anon_apfvhe*)@this)->field_0, b, a) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
