using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_choose_pivot_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal12choose_pivotINS0_14ArrayFixedSizeILm8EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEmRKT_RKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::choose_pivot<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&")] void* Array, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		long b = 0L;
		long c = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = ArrayFixedSize_8ul_len.Invoke(Array);
		unchecked
		{
			long result;
			if ((ulong)num < 8uL)
			{
				result = 0L;
			}
			else
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num2);
				num2 = (long)((ulong)num / 8uL);
				Llvm_lifetime_start_p0.Invoke(8L, &num3);
				num3 = 0L;
				Llvm_lifetime_start_p0.Invoke(8L, &b);
				b = num2 * 4L;
				Llvm_lifetime_start_p0.Invoke(8L, &c);
				c = num2 * 7L;
				result = (((ulong)num >= 64uL) ? Internal_median3_rec_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, 0L, b, c, num2, Is_less) : Internal_median3_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, 0L, b, c, Is_less));
				Llvm_lifetime_end_p0.Invoke(8L, &c);
				Llvm_lifetime_end_p0.Invoke(8L, &b);
				Llvm_lifetime_end_p0.Invoke(8L, &num3);
				Llvm_lifetime_end_p0.Invoke(8L, &num2);
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
