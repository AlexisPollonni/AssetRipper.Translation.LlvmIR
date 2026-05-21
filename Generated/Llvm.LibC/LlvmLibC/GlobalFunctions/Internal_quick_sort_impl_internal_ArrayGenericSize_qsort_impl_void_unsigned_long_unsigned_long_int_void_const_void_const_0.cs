using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_quick_sort_impl_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_16ArrayGenericSizeEZNS_14__qsort_impl__EPvmmPFiPKvS5_EE3$_0EEvRT_S5_mRKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayGenericSize&")] void* Array, [MangledName("ancestor_pivot")][NativeType("void const*")] void* Ancestor_pivot, [MangledName("limit")][NativeType("unsigned long")] long Limit, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		Anon_7y5tgm anon_7y5tgm = default(Anon_7y5tgm);
		long num4 = 0L;
		Llvm_libc_20_1_2_scanf_core_ReadBuffer llvm_libc_20_1_2_scanf_core_ReadBuffer = default(Llvm_libc_20_1_2_scanf_core_ReadBuffer);
		void* ptr = null;
		long num5 = 0L;
		Llvm_libc_20_1_2_scanf_core_ReadBuffer llvm_libc_20_1_2_scanf_core_ReadBuffer2 = default(Llvm_libc_20_1_2_scanf_core_ReadBuffer);
		void* ptr2 = Ancestor_pivot;
		long num6 = Limit;
		unchecked
		{
			while (true)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = ArrayGenericSize_len.Invoke(Array);
				int num7;
				if ((ulong)num <= 1uL)
				{
					num7 = 1;
				}
				else if (num6 == 0L)
				{
					Internal_heap_sort_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, Is_less);
					num7 = 1;
				}
				else
				{
					num6--;
					Llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = Internal_choose_pivot_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, Is_less);
					if (ptr2 != null && !_0_Invoke_4rap2e.Invoke(Is_less, ptr2, ArrayGenericSize_get.Invoke(Array, num2)))
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num3);
						long pivot_index = num2;
						Llvm_lifetime_start_p0.Invoke(8L, &anon_7y5tgm);
						Llvm_memcpy_p0_p0_i64.Invoke(&anon_7y5tgm.field_0, Is_less, 8L, isVolatile: false);
						long num8 = Internal_partition_internal_ArrayGenericSize_void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const_lambda_void_const_void_const.Invoke(Array, pivot_index, &anon_7y5tgm);
						Llvm_lifetime_end_p0.Invoke(8L, &anon_7y5tgm);
						num3 = num8;
						ArrayGenericSize_reset_bounds.Invoke(Array, num3 + 1L, ArrayGenericSize_len.Invoke(Array) - (num3 + 1L));
						ptr2 = null;
						num7 = 2;
						Llvm_lifetime_end_p0.Invoke(8L, &num3);
					}
					else
					{
						Llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = Internal_partition_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, num2, Is_less);
						if (num == 2L)
						{
							num7 = 1;
						}
						else
						{
							Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_scanf_core_ReadBuffer);
							*(IntPtr*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer) = unchecked((nint)(-6148914691236517206L));
							((long*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer))[1] = -6148914691236517206L;
							((long*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer))[2] = -6148914691236517206L;
							ArrayGenericSize_make_array.Invoke(&llvm_libc_20_1_2_scanf_core_ReadBuffer, Array, 0L, num4);
							Llvm_lifetime_start_p0.Invoke(8L, &ptr);
							ptr = ArrayGenericSize_get.Invoke(Array, num4);
							Llvm_lifetime_start_p0.Invoke(8L, &num5);
							num5 = num4 + 1L;
							Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_scanf_core_ReadBuffer2);
							*(IntPtr*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer2) = unchecked((nint)(-6148914691236517206L));
							((long*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer2))[1] = -6148914691236517206L;
							((long*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer2))[2] = -6148914691236517206L;
							ArrayGenericSize_make_array.Invoke(&llvm_libc_20_1_2_scanf_core_ReadBuffer2, Array, num5, ArrayGenericSize_len.Invoke(Array) - num5);
							Invoke(&llvm_libc_20_1_2_scanf_core_ReadBuffer, ptr2, num6, Is_less);
							Llvm_memcpy_p0_p0_i64.Invoke(Array, &llvm_libc_20_1_2_scanf_core_ReadBuffer2, 24L, isVolatile: false);
							ptr2 = ptr;
							Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_scanf_core_ReadBuffer2);
							Llvm_lifetime_end_p0.Invoke(8L, &num5);
							Llvm_lifetime_end_p0.Invoke(8L, &ptr);
							Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_scanf_core_ReadBuffer);
							num7 = 0;
						}
						Llvm_lifetime_end_p0.Invoke(8L, &num4);
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num2);
				}
				Llvm_lifetime_end_p0.Invoke(8L, &num);
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
