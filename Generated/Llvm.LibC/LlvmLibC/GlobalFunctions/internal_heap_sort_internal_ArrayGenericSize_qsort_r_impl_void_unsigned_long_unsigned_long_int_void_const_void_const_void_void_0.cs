using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_heap_sort_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9heap_sortINS0_16ArrayGenericSizeEZNS_16__qsort_r_impl__EPvmmPFiPKvS5_S3_ES3_E3$_0EEvRKT_RKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::heap_sort<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayGenericSize const&")] void* array, [NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		long i = 0L;
		long num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = ArrayGenericSize_len.Invoke(array);
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
					ArrayGenericSize_swap.Invoke(array, 0L, num);
				}
				llvm_lifetime_start_p0.Invoke(8L, &i);
				i = num2;
				while ((ulong)lambda_Invoke_bef9dh.Invoke(&anon_izyfb8, i) < (ulong)num)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = lambda_Invoke_bef9dh.Invoke(&anon_izyfb8, i);
					if ((ulong)(num3 + 1L) < (ulong)num && _0_Invoke_kq6gnz.Invoke(is_less, ArrayGenericSize_get.Invoke(array, num3), ArrayGenericSize_get.Invoke(array, num3 + 1L)))
					{
						num3++;
					}
					int num4;
					if (!_0_Invoke_kq6gnz.Invoke(is_less, ArrayGenericSize_get.Invoke(array, i), ArrayGenericSize_get.Invoke(array, num3)))
					{
						num4 = 5;
					}
					else
					{
						ArrayGenericSize_swap.Invoke(array, i, num3);
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
