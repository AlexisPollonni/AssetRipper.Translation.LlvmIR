using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_partition_lomuto_branchless_internal_ArrayFixedSize_16ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal27partition_lomuto_branchlessINS0_14ArrayFixedSizeILm16EEEZNS_16__qsort_r_impl__EPvmmPFiPKvS6_S4_ES4_E3$_0EEmRKT_S6_RKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition_lomuto_branchless<__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul>, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul> const&, void const*, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<16ul> const&")] void* array, [NativeType("void const*")] void* pivot, [NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		sbyte b = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = ArrayFixedSize_16ul_len.Invoke(array);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 0L;
		unchecked
		{
			while ((ulong)num3 < (ulong)num)
			{
				llvm_lifetime_start_p0.Invoke(1L, &b);
				b = (_0_Invoke_kq6gnz.Invoke(is_less, ArrayFixedSize_16ul_get.Invoke(array, num3), pivot) ? ((sbyte)1) : ((sbyte)0));
				ArrayFixedSize_16ul_swap.Invoke(array, num2, num3);
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
