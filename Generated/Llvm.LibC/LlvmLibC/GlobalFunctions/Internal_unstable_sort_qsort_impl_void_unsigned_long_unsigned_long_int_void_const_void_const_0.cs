using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_unstable_sort_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal13unstable_sortIZNS_14__qsort_impl__EPvmmPFiPKvS4_EE3$_0EEvS2_mmRKT_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::unstable_sort<__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(void*, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("array")][NativeType("void*")] void* Array, [MangledName("array_len")][NativeType("unsigned long")] long Array_len, [MangledName("elem_size")][NativeType("unsigned long")] long Elem_size, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		Internal_unstable_sort_impl_true_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, Array_len, Elem_size, Is_less);
	}
}
