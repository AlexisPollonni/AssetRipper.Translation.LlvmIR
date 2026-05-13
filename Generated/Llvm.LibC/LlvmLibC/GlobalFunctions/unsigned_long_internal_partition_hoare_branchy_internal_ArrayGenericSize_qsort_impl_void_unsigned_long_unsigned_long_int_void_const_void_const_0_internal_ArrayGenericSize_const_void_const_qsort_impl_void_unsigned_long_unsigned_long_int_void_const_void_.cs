using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal23partition_hoare_branchyINS0_16ArrayGenericSizeEZNS_14__qsort_impl__EPvmmPFiPKvS5_EE3$_0EEmRKT_S5_RKT0_")]
[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition_hoare_branchy<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, void const*, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
internal static partial class unsigned_long_internal_partition_hoare_branchy_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_internal_ArrayGenericSize_const_void_const_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const
{
	public unsafe static long Invoke(void* array, void* pivot, void* is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = internal_ArrayGenericSize_len_const.Invoke(array);
		llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = num;
		unchecked
		{
			while (true)
			{
				if ((ulong)num2 < (ulong)num3 && qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_operator_void_const_void_const_const.Invoke(is_less, internal_ArrayGenericSize_get_unsigned_long_const.Invoke(array, num2), pivot))
				{
					num2++;
					continue;
				}
				do
				{
					num3 += -1L;
				}
				while ((ulong)num2 < (ulong)num3 && !qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_operator_void_const_void_const_const.Invoke(is_less, internal_ArrayGenericSize_get_unsigned_long_const.Invoke(array, num3), pivot));
				if ((ulong)num2 >= (ulong)num3)
				{
					break;
				}
				internal_ArrayGenericSize_swap_unsigned_long_unsigned_long_const.Invoke(array, num2, num3);
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
