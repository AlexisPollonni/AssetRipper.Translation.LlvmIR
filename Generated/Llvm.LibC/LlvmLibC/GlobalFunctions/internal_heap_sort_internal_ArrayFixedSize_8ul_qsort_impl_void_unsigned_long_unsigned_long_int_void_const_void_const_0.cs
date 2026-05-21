using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_heap_sort_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9heap_sortINS0_14ArrayFixedSizeILm8EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEvRKT_RKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::heap_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&")] void* array, [NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		anon_izyfb7 anon_izyfb8 = default(anon_izyfb7);
		long i = 0L;
		long num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = ArrayFixedSize_8ul_len.Invoke(array);
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
					ArrayFixedSize_8ul_swap.Invoke(array, 0L, num);
				}
				llvm_lifetime_start_p0.Invoke(8L, &i);
				i = num2;
				while ((ulong)lambda_Invoke_augukk.Invoke(&anon_izyfb8, i) < (ulong)num)
				{
					llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = lambda_Invoke_augukk.Invoke(&anon_izyfb8, i);
					if ((ulong)(num3 + 1L) < (ulong)num && _0_Invoke_4rap2e.Invoke(is_less, ArrayFixedSize_8ul_get.Invoke(array, num3), ArrayFixedSize_8ul_get.Invoke(array, num3 + 1L)))
					{
						num3++;
					}
					int num4;
					if (!_0_Invoke_4rap2e.Invoke(is_less, ArrayFixedSize_8ul_get.Invoke(array, i), ArrayFixedSize_8ul_get.Invoke(array, num3)))
					{
						num4 = 5;
					}
					else
					{
						ArrayFixedSize_8ul_swap.Invoke(array, i, num3);
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
