using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_unstable_sort_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal13unstable_sortIZNS_16__qsort_r_impl__EPvmmPFiPKvS4_S2_ES2_E3$_0EEvS2_mmRKT_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::unstable_sort<__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(void*, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("void*")] void* array, [NativeType("unsigned long")] long array_len, [NativeType("unsigned long")] long elem_size, [NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* is_less)
	{
		internal_unstable_sort_impl_true_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(array, array_len, elem_size, is_less);
	}
}
