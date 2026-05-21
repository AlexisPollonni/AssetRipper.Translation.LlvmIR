using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_partition_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9partitionINS0_16ArrayGenericSizeEZNS_14__qsort_impl__EPvmmPFiPKvS5_EE3$_0EEmRKT_mRKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayGenericSize const&")] void* array, [NativeType("unsigned long")] long pivot_index, [NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* is_less)
	{
		scanf_core_ReadBuffer scanf_core_ReadBuffer2 = default(scanf_core_ReadBuffer);
		void* pivot = null;
		long num = 0L;
		if (pivot_index != 0L)
		{
			ArrayGenericSize_swap.Invoke(array, 0L, pivot_index);
		}
		llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer2);
		unchecked
		{
			*(IntPtr*)(&scanf_core_ReadBuffer2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&scanf_core_ReadBuffer2))[1] = -6148914691236517206L;
			((long*)(&scanf_core_ReadBuffer2))[2] = -6148914691236517206L;
			ArrayGenericSize_make_array.Invoke(&scanf_core_ReadBuffer2, array, 1L, ArrayGenericSize_len.Invoke(array) - 1L);
			llvm_lifetime_start_p0.Invoke(8L, &pivot);
			pivot = ArrayGenericSize_get.Invoke(array, 0L);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = -6148914691236517206L;
			num = internal_partition_hoare_branchy_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(&scanf_core_ReadBuffer2, pivot, is_less);
			ArrayGenericSize_swap.Invoke(array, 0L, num);
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &pivot);
			llvm_lifetime_end_p0.Invoke(24L, &scanf_core_ReadBuffer2);
			return result;
		}
	}
}
