using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12choose_pivotINS0_14ArrayFixedSizeILm8EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEmRKT_RKT0_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::choose_pivot<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class unsigned_long_internal_choose_pivot_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static long Invoke(void* array, void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long b = 0L;
		long c = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_ArrayFixedSize_8ul_len_const.Invoke(array);
		unchecked
		{
			long result;
			if ((ulong)num < 8uL)
			{
				result = 0L;
			}
			else
			{
				llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = (long)((ulong)num / 8uL);
				llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = 0L;
				llvm_lifetime_start_p0.Invoke(8L, &b);
				b = num2 * 4L;
				llvm_lifetime_start_p0.Invoke(8L, &c);
				c = num2 * 7L;
				result = (((ulong)num >= 64uL) ? unsigned_long_internal_median3_rec_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_unsigned_long_unsigned_long_unsigned_long_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, 0L, b, c, num2, is_less) : unsigned_long_internal_median3_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_unsigned_long_unsigned_long_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, 0L, b, c, is_less));
				llvm_lifetime_end_p0.Invoke(8L, &c);
				llvm_lifetime_end_p0.Invoke(8L, &b);
				llvm_lifetime_end_p0.Invoke(8L, &num3);
				llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
