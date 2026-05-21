using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_median3_rec_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal11median3_recINS0_14ArrayFixedSizeILm4EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEmRKT_mmmmRKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::median3_rec<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul> const&, unsigned long, unsigned long, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul> const&")] void* array, [NativeType("unsigned long")] long a, [NativeType("unsigned long")] long b, [NativeType("unsigned long")] long c, [NativeType("unsigned long")] long n, [NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* is_less)
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
			return internal_median3_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(array, num2, num3, num4, is_less);
		}
	}
}
