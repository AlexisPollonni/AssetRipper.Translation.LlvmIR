using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_partition_hoare_branchy_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal23partition_hoare_branchyINS0_16ArrayGenericSizeEZNS_14__qsort_impl__EPvmmPFiPKvS5_EE3$_0EEmRKT_S5_RKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::partition_hoare_branchy<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, void const*, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayGenericSize const&")] void* Array, [MangledName("pivot")][NativeType("void const*")] void* Pivot, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		long num = 0L;
		long num2 = 0L;
		long num3 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = ArrayGenericSize_len.Invoke(Array);
		Llvm_lifetime_start_p0.Invoke(8L, &num2);
		num2 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = num;
		unchecked
		{
			while (true)
			{
				if ((ulong)num2 < (ulong)num3 && _0_Invoke_4rap2e.Invoke(Is_less, ArrayGenericSize_get.Invoke(Array, num2), Pivot))
				{
					num2++;
					continue;
				}
				do
				{
					num3 += -1L;
				}
				while ((ulong)num2 < (ulong)num3 && !_0_Invoke_4rap2e.Invoke(Is_less, ArrayGenericSize_get.Invoke(Array, num3), Pivot));
				if ((ulong)num2 >= (ulong)num3)
				{
					break;
				}
				ArrayGenericSize_swap.Invoke(Array, num2, num3);
				num2++;
			}
			long result = num2;
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(8L, &num2);
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			return result;
		}
	}
}
