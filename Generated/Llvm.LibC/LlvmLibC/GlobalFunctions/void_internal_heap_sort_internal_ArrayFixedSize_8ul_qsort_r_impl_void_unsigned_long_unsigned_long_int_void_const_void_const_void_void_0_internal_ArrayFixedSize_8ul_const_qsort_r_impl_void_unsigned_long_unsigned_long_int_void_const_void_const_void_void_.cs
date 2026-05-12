using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal9heap_sortINS0_14ArrayFixedSizeILm8EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRKT_RKT0_")]
[DemangledName("void __llvm_libc_20_1_2_::internal::heap_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
internal static partial class void_internal_heap_sort_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const
{
	public unsafe static void Invoke(void* array, void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		long i = 0L;
		long num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_ArrayFixedSize_8ul_len_const.Invoke(array);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = (long)((ulong)num / 2uL);
			llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb8);
			*(sbyte*)(&anon_izyfb8) = -86;
			while ((ulong)num > 1uL)
			{
				if ((ulong)num2 > 0uL)
				{
					num2 += -1L;
				}
				else
				{
					num += -1L;
					internal_ArrayFixedSize_8ul_swap_unsigned_long_unsigned_long_const.Invoke(array, 0L, num);
				}
				llvm_lifetime_start_p0.Invoke(8L, &i);
				i = num2;
				while ((ulong)void_internal_heap_sort_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_unsigned_long_operator_unsigned_long_const.Invoke(&anon_izyfb8, i) < (ulong)num)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = void_internal_heap_sort_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_unsigned_long_operator_unsigned_long_const.Invoke(&anon_izyfb8, i);
					if ((ulong)(num3 + 1L) < (ulong)num && qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_operator_void_const_void_const_const.Invoke(is_less, internal_ArrayFixedSize_8ul_get_unsigned_long_const.Invoke(array, num3), internal_ArrayFixedSize_8ul_get_unsigned_long_const.Invoke(array, num3 + 1L)))
					{
						num3++;
					}
					int num4;
					if (!qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_operator_void_const_void_const_const.Invoke(is_less, internal_ArrayFixedSize_8ul_get_unsigned_long_const.Invoke(array, i), internal_ArrayFixedSize_8ul_get_unsigned_long_const.Invoke(array, num3)))
					{
						num4 = 5;
					}
					else
					{
						internal_ArrayFixedSize_8ul_swap_unsigned_long_unsigned_long_const.Invoke(array, i, num3);
						i = num3;
						num4 = 0;
					}
					llvm_lifetime_end_p0.Invoke(8L, &num3);
					switch (num4)
					{
					case 0:
						continue;
					case 5:
						break;
					default:
						throw new NotImplementedException("Reached LLVM unreachable instruction.");
					}
					break;
				}
				llvm_lifetime_end_p0.Invoke(8L, &i);
			}
			llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb8);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
[MangledName("_ZZN19__llvm_libc_20_1_2_8internal9heap_sortINS0_14ArrayFixedSizeILm8EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEvRKT_RKT0_ENKUlmE_clEm")]
[DemangledName("void __llvm_libc_20_1_2_::internal::heap_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(unsigned long)::operator()(unsigned long) const")]
internal static partial class void_internal_heap_sort_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_internal_ArrayFixedSize_8ul_const_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const_lambda_unsigned_long_operator_unsigned_long_const
{
	public unsafe static long Invoke(void* @this, long i)
	{
		return unchecked(2L * i + 1L);
	}
}
