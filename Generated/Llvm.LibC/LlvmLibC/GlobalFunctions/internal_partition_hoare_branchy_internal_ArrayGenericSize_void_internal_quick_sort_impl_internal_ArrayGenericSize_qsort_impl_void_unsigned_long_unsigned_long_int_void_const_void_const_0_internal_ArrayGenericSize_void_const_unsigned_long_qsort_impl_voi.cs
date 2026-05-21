using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_partition_hoare_branchy_internal_ArrayGenericSize_void_internal_quick_sort_impl_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_internal_ArrayGenericSize_void_const_unsigned_long_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const_lambda_void_const_void_const
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal23partition_hoare_branchyINS0_16ArrayGenericSizeEZNS0_15quick_sort_implIS2_ZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEvRT_S6_mRKT0_EUlS6_S6_E_EEmRKSA_S6_SE_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition_hoare_branchy<__llvm_libc_20_1_2_::internal::ArrayGenericSize, void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)::'lambda'(void const*, void const*)>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, void const*, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayGenericSize const&")] void* array, [NativeType("void const*")] void* pivot, [NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = ArrayGenericSize_len.Invoke(array);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = num;
		unchecked
		{
			while (true)
			{
				if ((ulong)num2 < (ulong)num3 && lambda_Invoke_dytp22.Invoke(is_less, ArrayGenericSize_get.Invoke(array, num2), pivot))
				{
					num2++;
					continue;
				}
				do
				{
					num3 += -1L;
				}
				while ((ulong)num2 < (ulong)num3 && !lambda_Invoke_dytp22.Invoke(is_less, ArrayGenericSize_get.Invoke(array, num3), pivot));
				if ((ulong)num2 >= (ulong)num3)
				{
					break;
				}
				ArrayGenericSize_swap.Invoke(array, num2, num3);
				num2++;
			}
			long result = num2;
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(8L, &num2);
			llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
