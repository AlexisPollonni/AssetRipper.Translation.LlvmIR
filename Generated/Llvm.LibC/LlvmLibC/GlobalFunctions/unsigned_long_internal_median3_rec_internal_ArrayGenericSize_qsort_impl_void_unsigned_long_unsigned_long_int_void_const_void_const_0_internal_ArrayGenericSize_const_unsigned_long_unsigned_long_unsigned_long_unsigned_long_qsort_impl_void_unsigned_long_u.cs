using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal11median3_recINS0_16ArrayGenericSizeEZNS_14__qsort_impl__EPvmmPFiPKvS5_EE3$_0EEmRKT_mmmmRKT0_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::median3_rec<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, unsigned long, unsigned long, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
internal static partial class unsigned_long_internal_median3_rec_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_internal_ArrayGenericSize_const_unsigned_long_unsigned_long_unsigned_long_unsigned_long_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const
{
	public unsafe static long Invoke(void* array, long a, long b, long c, long n, void* is_less)
	{
		long num = 0L;
		long num2 = a;
		long num3 = b;
		long num4 = c;
		unchecked
		{
			if ((ulong)(n * 8L) >= 64uL)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num);
				num = (long)((ulong)n / 8uL);
				num2 = Invoke(array, num2, num2 + num * 4L, num2 + num * 7L, num, is_less);
				num3 = Invoke(array, num3, num3 + num * 4L, num3 + num * 7L, num, is_less);
				num4 = Invoke(array, num4, num4 + num * 4L, num4 + num * 7L, num, is_less);
				llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return unsigned_long_internal_median3_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_internal_ArrayGenericSize_const_unsigned_long_unsigned_long_unsigned_long_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const.Invoke(array, num2, num3, num4, is_less);
		}
	}
}
