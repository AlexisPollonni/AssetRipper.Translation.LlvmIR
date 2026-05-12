using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_14ArrayFixedSizeILm4EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRT_S6_mRKT0_")]
[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class void_internal_quick_sort_impl_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static void Invoke(void* array, void* ancestor_pivot, long limit, void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		anon_apfvhe anon_apfvhe2 = default(anon_apfvhe);
		long num4 = 0L;
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		void* ptr = null;
		long num5 = 0L;
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		void* ptr2 = ancestor_pivot;
		long num6 = limit;
		unchecked
		{
			while (true)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = internal_ArrayFixedSize_4ul_len_const.Invoke(array);
				int num7;
				if ((ulong)num <= 1uL)
				{
					num7 = 1;
				}
				else if (num6 == 0L)
				{
					void_internal_heap_sort_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, is_less);
					num7 = 1;
				}
				else
				{
					num6--;
					llvm_lifetime_start_p0.Invoke(8L, &num2);
					num2 = unsigned_long_internal_choose_pivot_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, is_less);
					if (ptr2 != null && !qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_operator_void_const_void_const_const.Invoke(is_less, ptr2, internal_ArrayFixedSize_4ul_get_unsigned_long_const.Invoke(array, num2)))
					{
						llvm_lifetime_start_p0.Invoke(8L, &num3);
						long pivot_index = num2;
						llvm_lifetime_start_p0.Invoke(16L, &anon_apfvhe2);
						llvm_memcpy_p0_p0_i64.Invoke(&anon_apfvhe2.field_0, is_less, 16L, isVolatile: false);
						long num8 = unsigned_long_internal_partition_internal_ArrayFixedSize_4ul_void_internal_quick_sort_impl_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_internal_ArrayFixedSize_4ul_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, pivot_index, &anon_apfvhe2);
						llvm_lifetime_end_p0.Invoke(16L, &anon_apfvhe2);
						num3 = num8;
						internal_ArrayFixedSize_4ul_reset_bounds_unsigned_long_unsigned_long.Invoke(array, num3 + 1L, internal_ArrayFixedSize_4ul_len_const.Invoke(array) - (num3 + 1L));
						ptr2 = null;
						num7 = 2;
						llvm_lifetime_end_p0.Invoke(8L, &num3);
					}
					else
					{
						llvm_lifetime_start_p0.Invoke(8L, &num4);
						num4 = unsigned_long_internal_partition_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, num2, is_less);
						if (num == 2L)
						{
							num7 = 1;
						}
						else
						{
							llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
							*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
							((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
							Struct_kqhe8i struct_kqhe8i = internal_ArrayFixedSize_4ul_make_array_unsigned_long_unsigned_long_const.Invoke(array, 0L, num4);
							cpp_string_view* num9 = &cpp_string_view2;
							Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
							*(void**)num9 = struct_kqhe8i2.field_0;
							byte* num10 = (byte*)(&cpp_string_view2) + 8u;
							Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
							*(long*)num10 = struct_kqhe8i3.field_1;
							llvm_lifetime_start_p0.Invoke(8L, &ptr);
							ptr = internal_ArrayFixedSize_4ul_get_unsigned_long_const.Invoke(array, num4);
							llvm_lifetime_start_p0.Invoke(8L, &num5);
							num5 = num4 + 1L;
							llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view3);
							*(IntPtr*)(&cpp_string_view3) = unchecked((nint)(-6148914691236517206L));
							((long*)(&cpp_string_view3))[1] = -6148914691236517206L;
							Struct_kqhe8i struct_kqhe8i4 = internal_ArrayFixedSize_4ul_make_array_unsigned_long_unsigned_long_const.Invoke(array, num5, internal_ArrayFixedSize_4ul_len_const.Invoke(array) - num5);
							cpp_string_view* num11 = &cpp_string_view3;
							Struct_kqhe8i struct_kqhe8i5 = struct_kqhe8i4;
							*(void**)num11 = struct_kqhe8i5.field_0;
							byte* num12 = (byte*)(&cpp_string_view3) + 8u;
							Struct_kqhe8i struct_kqhe8i6 = struct_kqhe8i4;
							*(long*)num12 = struct_kqhe8i6.field_1;
							Invoke(&cpp_string_view2, ptr2, num6, is_less);
							llvm_memcpy_p0_p0_i64.Invoke(array, &cpp_string_view3, 16L, isVolatile: false);
							ptr2 = ptr;
							llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view3);
							llvm_lifetime_end_p0.Invoke(8L, &num5);
							llvm_lifetime_end_p0.Invoke(8L, &ptr);
							llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
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
[MangledName("_ZZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_14ArrayFixedSizeILm4EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRT_S6_mRKT0_ENKUlS6_S6_E_clES6_S6_")]
[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(void const*, void const*)::operator()(void const*, void const*) const")]
internal static partial class void_internal_quick_sort_impl_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_4ul_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const_operator_void_const_void_const_const
{
	public unsafe static bool Invoke(void* @this, void* a, void* b)
	{
		return unchecked((byte)((qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_operator_void_const_void_const_const.Invoke(&((anon_apfvhe*)@this)->field_0, b, a) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
