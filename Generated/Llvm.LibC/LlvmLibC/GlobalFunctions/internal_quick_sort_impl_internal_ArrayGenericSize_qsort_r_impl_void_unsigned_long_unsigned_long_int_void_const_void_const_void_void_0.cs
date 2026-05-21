using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_16ArrayGenericSizeEZNS_16__qsort_r_impl__EPvmmPFiPKvS5_S3_ES3_E3$_0EEvRT_S5_mRKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayGenericSize&")] void* array, [NativeType("void const*")] void* ancestor_pivot, [NativeType("unsigned long")] long limit, [NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		anon_e6q534 anon_e6q535 = default(anon_e6q534);
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
				num = ArrayGenericSize_len.Invoke(array);
				int num7;
				if ((ulong)num <= 1uL)
				{
					num7 = 1;
				}
				else if (num6 == 0L)
				{
					internal_heap_sort_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(array, is_less);
					num7 = 1;
				}
				else
				{
					num6--;
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = internal_choose_pivot_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(array, is_less);
					if (ptr2 != null && !_0_Invoke_kq6gnz.Invoke(is_less, ptr2, ArrayGenericSize_get.Invoke(array, num2)))
					{
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						long pivot_index = num2;
						llvm_lifetime_start_p0.Invoke(16L, &anon_e6q535);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_e6q535.field_0, is_less, 16L, isVolatile: false);
						long num8 = internal_partition_internal_ArrayGenericSize_void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const.Invoke(array, pivot_index, &anon_e6q535);
						llvm_lifetime_end_p0.Invoke(16L, &anon_e6q535);
						num3 = num8;
						ArrayGenericSize_reset_bounds.Invoke(array, num3 + 1L, ArrayGenericSize_len.Invoke(array) - (num3 + 1L));
						ptr2 = null;
						num7 = 2;
						llvm_lifetime_end_p0.Invoke(8L, &num3);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = internal_partition_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(array, num2, is_less);
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
							ArrayGenericSize_make_array.Invoke(&scanf_core_ReadBuffer2, array, 0L, num4);
							llvm_lifetime_start_p0.Invoke(8L, &ptr);
							ptr = ArrayGenericSize_get.Invoke(array, num4);
							llvm_lifetime_start_p0.Invoke(8L, &num5);
							num5 = num4 + 1L;
							llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer3);
							*(IntPtr*)(&scanf_core_ReadBuffer3) = unchecked((nint)(-6148914691236517206L));
							((long*)(&scanf_core_ReadBuffer3))[1] = -6148914691236517206L;
							((long*)(&scanf_core_ReadBuffer3))[2] = -6148914691236517206L;
							ArrayGenericSize_make_array.Invoke(&scanf_core_ReadBuffer3, array, num5, ArrayGenericSize_len.Invoke(array) - num5);
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
