using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_partition_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9partitionINS0_14ArrayFixedSizeILm8EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEmRKT_mRKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&")] void* array, [NativeType("unsigned long")] long pivot_index, [NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* is_less)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		void* pivot = null;
		long num = 0L;
		if (pivot_index != 0L)
		{
			ArrayFixedSize_8ul_swap.Invoke(array, 0L, pivot_index);
		}
		llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
		unchecked
		{
			*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
			((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
			Struct_kqhe8i struct_kqhe8i = ArrayFixedSize_8ul_make_array.Invoke(array, 1L, ArrayFixedSize_8ul_len.Invoke(array) - 1L);
			cpp_string_view* num2 = &cpp_string_view2;
			Struct_kqhe8i struct_kqhe8i2 = struct_kqhe8i;
			*(void**)num2 = struct_kqhe8i2.field_0;
			byte* num3 = (byte*)(&cpp_string_view2) + 8u;
			Struct_kqhe8i struct_kqhe8i3 = struct_kqhe8i;
			*(long*)num3 = struct_kqhe8i3.field_1;
			llvm_lifetime_start_p0.Invoke(8L, &pivot);
			pivot = ArrayFixedSize_8ul_get.Invoke(array, 0L);
			llvm_lifetime_start_p0.Invoke(8L, &num);
			num = -6148914691236517206L;
			num = internal_partition_lomuto_branchless_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(&cpp_string_view2, pivot, is_less);
			ArrayFixedSize_8ul_swap.Invoke(array, 0L, num);
			long result = num;
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &pivot);
			llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
			return result;
		}
	}
}
