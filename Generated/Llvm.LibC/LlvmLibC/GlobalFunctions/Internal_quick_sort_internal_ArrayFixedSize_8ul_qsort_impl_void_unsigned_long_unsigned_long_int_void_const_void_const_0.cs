using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_quick_sort_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal10quick_sortINS0_14ArrayFixedSizeILm8EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEvRT_RKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>&, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>&")] void* Array, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		void* ancestor_pivot = null;
		long limit = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &ancestor_pivot);
		ancestor_pivot = null;
		Llvm_lifetime_start_p0.Invoke(8L, &limit);
		limit = unchecked(2L * Internal_ilog2.Invoke(ArrayFixedSize_8ul_len.Invoke(Array) | 1L));
		Internal_quick_sort_impl_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, ancestor_pivot, limit, Is_less);
		Llvm_lifetime_end_p0.Invoke(8L, &limit);
		Llvm_lifetime_end_p0.Invoke(8L, &ancestor_pivot);
	}
}
