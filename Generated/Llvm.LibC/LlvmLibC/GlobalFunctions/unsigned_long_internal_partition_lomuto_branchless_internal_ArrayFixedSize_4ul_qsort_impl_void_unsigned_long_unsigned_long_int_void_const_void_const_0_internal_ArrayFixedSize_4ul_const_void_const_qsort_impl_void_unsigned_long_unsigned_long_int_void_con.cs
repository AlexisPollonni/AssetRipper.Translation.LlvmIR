using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal27partition_lomuto_branchlessINS0_14ArrayFixedSizeILm4EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEmRKT_S6_RKT0_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition_lomuto_branchless<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul> const&, void const*, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
internal static partial class unsigned_long_internal_partition_lomuto_branchless_internal_ArrayFixedSize_4ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_internal_ArrayFixedSize_4ul_const_void_const_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const
{
	public unsafe static long Invoke(void* array, void* pivot, void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_ArrayFixedSize_4ul_len_const.Invoke(array);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 0L;
		unchecked
		{
			while ((ulong)num3 < (ulong)num)
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_operator_void_const_void_const_const.Invoke(is_less, internal_ArrayFixedSize_4ul_get_unsigned_long_const.Invoke(array, num3), pivot) ? ((sbyte)1) : ((sbyte)0));
				internal_ArrayFixedSize_4ul_swap_unsigned_long_unsigned_long_const.Invoke(array, num2, num3);
				num2 += (((b & 1) == 1) ? 1L : 0L);
				num3++;
				llvm_lifetime_end_p0.Invoke(1L, &b);
			}
			long result = num2;
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
