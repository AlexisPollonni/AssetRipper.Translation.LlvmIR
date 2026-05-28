using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_partition_internal_ArrayGenericSize_void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9partitionINS0_16ArrayGenericSizeEZNS0_15quick_sort_implIS2_ZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRT_S6_mRKT0_EUlS6_S6_E_EEmRKSA_mSE_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition<__llvm_libc_20_1_2_::internal::ArrayGenericSize, void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(void const*, void const*)>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayGenericSize const&")] void* Array, [MangledName("pivot_index")][NativeType("unsigned long")] long Pivot_index, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* Is_less)
	{
		Scanf_core_ReadBuffer scanf_core_ReadBuffer = default(Scanf_core_ReadBuffer);
		void* pivot = null;
		long num = 0L;
		if (Pivot_index != 0L)
		{
			ArrayGenericSize_swap.Invoke(Array, 0L, Pivot_index);
		}
		Llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer);
		unchecked
		{
			*(IntPtr*)(&scanf_core_ReadBuffer) = unchecked((nint)(-6148914691236517206L));
			((long*)(&scanf_core_ReadBuffer))[1] = -6148914691236517206L;
			((long*)(&scanf_core_ReadBuffer))[2] = -6148914691236517206L;
			ArrayGenericSize_make_array.Invoke(&scanf_core_ReadBuffer, Array, 1L, ArrayGenericSize_len.Invoke(Array) - 1L);
			Llvm_lifetime_start_p0.Invoke(8L, &pivot);
			pivot = ArrayGenericSize_get.Invoke(Array, 0L);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = -6148914691236517206L;
			num = Internal_partition_hoare_branchy_internal_ArrayGenericSize_void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const.Invoke(&scanf_core_ReadBuffer, pivot, Is_less);
			ArrayGenericSize_swap.Invoke(Array, 0L, num);
			long result = num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &pivot);
			Llvm_lifetime_end_p0.Invoke(24L, &scanf_core_ReadBuffer);
			return result;
		}
	}
}
