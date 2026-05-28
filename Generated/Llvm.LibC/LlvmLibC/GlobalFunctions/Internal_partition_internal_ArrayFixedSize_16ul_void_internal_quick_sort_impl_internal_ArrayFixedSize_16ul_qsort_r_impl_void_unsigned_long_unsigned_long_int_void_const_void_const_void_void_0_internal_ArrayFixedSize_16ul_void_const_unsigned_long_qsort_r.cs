using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_partition_internal_ArrayFixedSize_16ul_void_internal_quick_sort_impl_internal_ArrayFixedSize_16ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_16ul_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9partitionINS0_14ArrayFixedSizeILm16EEEZNS0_15quick_sort_implIS3_ZNS_16__qsort_r_impl__EPvmmPFiPKvS7_S5_ES5_E3$_0EEvRT_S7_mRKT0_EUlS7_S7_E_EEmRKSB_mSF_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition<__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>, void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(void const*, void const*)>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul> const&, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul> const&")] void* Array, [MangledName("pivot_index")][NativeType("unsigned long")] long Pivot_index, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* Is_less)
	{
		Cpp_string_view cpp_string_view = default(Cpp_string_view);
		void* pivot = null;
		long num = 0L;
		if (Pivot_index != 0L)
		{
			ArrayFixedSize_16ul_swap.Invoke(Array, 0L, Pivot_index);
		}
		Llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view);
		unchecked
		{
			*(IntPtr*)(&cpp_string_view) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view))[1] = -6148914691236517206L;
			Struct_kqhe8i struct_kqhe8i = ArrayFixedSize_16ul_make_array.Invoke(Array, 1L, ArrayFixedSize_16ul_len.Invoke(Array) - 1L);
			Cpp_string_view* num2 = &cpp_string_view;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num2 = struct_kqhe8i2.field_0;
			byte* num3 = (byte*)(&cpp_string_view) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num3 = struct_kqhe8i3.field_1;
			Llvm_lifetime_start_p0.Invoke(8L, &pivot);
			pivot = ArrayFixedSize_16ul_get.Invoke(Array, 0L);
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			num = -6148914691236517206L;
			num = Internal_partition_lomuto_branchless_internal_ArrayFixedSize_16ul_void_internal_quick_sort_impl_internal_ArrayFixedSize_16ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_16ul_void_const_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_void_const_void_const.Invoke(&cpp_string_view, pivot, Is_less);
			ArrayFixedSize_16ul_swap.Invoke(Array, 0L, num);
			long result = num;
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &pivot);
			Llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view);
			return result;
		}
	}
}
