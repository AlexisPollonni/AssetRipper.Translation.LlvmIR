using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_heap_sort_internal_ArrayFixedSize_4ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal9heap_sortINS0_14ArrayFixedSizeILm4EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEvRKT_RKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::heap_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul> const&, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul> const&")] void* Array, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		long num = 0L;
		long num2 = 0L;
		Anon_izyfb7 anon_izyfb = default(Anon_izyfb7);
		long i = 0L;
		long num3 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = ArrayFixedSize_4ul_len.Invoke(Array);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		unchecked
		{
			num2 = (long)((ulong)num / 2uL);
			Llvm_lifetime_start_p0.Invoke(1L, &anon_izyfb);
			*(sbyte*)(&anon_izyfb) = -86;
			while ((ulong)num > 1uL)
			{
				if ((ulong)num2 > 0uL)
				{
					num2 += -1L;
				}
				else
				{
					num += -1L;
					ArrayFixedSize_4ul_swap.Invoke(Array, 0L, num);
				}
				Llvm_lifetime_start_p0.Invoke(8L, &i);
				i = num2;
				while ((ulong)Lambda_Invoke_age6vb.Invoke(&anon_izyfb, i) < (ulong)num)
				{
					Llvm_lifetime_start_p0.Invoke(8L, &num3);
					num3 = Lambda_Invoke_age6vb.Invoke(&anon_izyfb, i);
					if ((ulong)(num3 + 1L) < (ulong)num && _0_Invoke_4rap2e.Invoke(Is_less, ArrayFixedSize_4ul_get.Invoke(Array, num3), ArrayFixedSize_4ul_get.Invoke(Array, num3 + 1L)))
					{
						num3++;
					}
					int num4;
					if (!_0_Invoke_4rap2e.Invoke(Is_less, ArrayFixedSize_4ul_get.Invoke(Array, i), ArrayFixedSize_4ul_get.Invoke(Array, num3)))
					{
						num4 = 5;
					}
					else
					{
						ArrayFixedSize_4ul_swap.Invoke(Array, i, num3);
						i = num3;
						num4 = 0;
					}
					Llvm_lifetime_end_p0.Invoke(8L, &num3);
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
				Llvm_lifetime_end_p0.Invoke(8L, &i);
			}
			Llvm_lifetime_end_p0.Invoke(1L, &anon_izyfb);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
