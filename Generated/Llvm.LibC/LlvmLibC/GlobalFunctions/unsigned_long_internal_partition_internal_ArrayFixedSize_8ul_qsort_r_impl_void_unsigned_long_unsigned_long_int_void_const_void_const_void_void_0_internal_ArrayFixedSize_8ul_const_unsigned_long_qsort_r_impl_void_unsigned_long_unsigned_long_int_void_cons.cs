using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal9partitionINS0_14ArrayFixedSizeILm8EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEmRKT_mRKT0_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class unsigned_long_internal_partition_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static long Invoke(void* array, long pivot_index, void* is_less)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		void* pivot = null;
		long num = 0L;
		if (pivot_index != 0L)
		{
			internal_ArrayFixedSize_8ul_swap_unsigned_long_unsigned_long_const.Invoke(array, 0L, pivot_index);
		}
		llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
		unchecked
		{
			*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
			Struct_kqhe8i struct_kqhe8i = internal_ArrayFixedSize_8ul_make_array_unsigned_long_unsigned_long_const.Invoke(array, 1L, internal_ArrayFixedSize_8ul_len_const.Invoke(array) - 1L);
			cpp_string_view* num2 = &cpp_string_view2;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num2 = struct_kqhe8i2.field_0;
			byte* num3 = (byte*)(&cpp_string_view2) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num3 = struct_kqhe8i3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &pivot);
			pivot = internal_ArrayFixedSize_8ul_get_unsigned_long_const.Invoke(array, 0L);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = -6148914691236517206L;
			num = unsigned_long_internal_partition_lomuto_branchless_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_void_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(&cpp_string_view2, pivot, is_less);
			internal_ArrayFixedSize_8ul_swap_unsigned_long_unsigned_long_const.Invoke(array, 0L, num);
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &pivot);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			return result;
		}
	}
}
