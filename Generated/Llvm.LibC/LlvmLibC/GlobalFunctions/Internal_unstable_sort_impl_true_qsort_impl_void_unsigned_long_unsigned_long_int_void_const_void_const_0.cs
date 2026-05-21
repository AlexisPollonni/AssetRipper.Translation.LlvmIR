using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_unstable_sort_impl_true_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18unstable_sort_implILb1EZNS_14__qsort_impl__EPvmmPFiPKvS4_EE3$_0EEvS2_mmRKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::unstable_sort_impl<true, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(void*, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("array")][NativeType("void*")] void* Array, [MangledName("array_len")][NativeType("unsigned long")] long Array_len, [MangledName("elem_size")][NativeType("unsigned long")] long Elem_size, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view2 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_cpp_string_view llvm_libc_20_1_2_cpp_string_view3 = default(Llvm_libc_20_1_2_cpp_string_view);
		Llvm_libc_20_1_2_scanf_core_ReadBuffer llvm_libc_20_1_2_scanf_core_ReadBuffer = default(Llvm_libc_20_1_2_scanf_core_ReadBuffer);
		unchecked
		{
			if (Array != null && Array_len != 0L && Elem_size != 0L)
			{
				switch (Elem_size)
				{
				case 4L:
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
					*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view) = unchecked((nint)(-6148914691236517206L));
					((long*)(&llvm_libc_20_1_2_cpp_string_view))[1] = -6148914691236517206L;
					ArrayFixedSize_4ul_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view, Array, Array_len);
					Internal_quick_sort_internal_ArrayFixedSize_4ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(&llvm_libc_20_1_2_cpp_string_view, Is_less);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view);
					break;
				case 8L:
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view2);
					*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
					((long*)(&llvm_libc_20_1_2_cpp_string_view2))[1] = -6148914691236517206L;
					ArrayFixedSize_8ul_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view2, Array, Array_len);
					Internal_quick_sort_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(&llvm_libc_20_1_2_cpp_string_view2, Is_less);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view2);
					break;
				case 16L:
					Llvm_lifetime_start_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view3);
					*(IntPtr*)(&llvm_libc_20_1_2_cpp_string_view3) = unchecked((nint)(-6148914691236517206L));
					((long*)(&llvm_libc_20_1_2_cpp_string_view3))[1] = -6148914691236517206L;
					ArrayFixedSize_16ul_Constructor.Invoke(&llvm_libc_20_1_2_cpp_string_view3, Array, Array_len);
					Internal_quick_sort_internal_ArrayFixedSize_16ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(&llvm_libc_20_1_2_cpp_string_view3, Is_less);
					Llvm_lifetime_end_p0.Invoke(16L, &llvm_libc_20_1_2_cpp_string_view3);
					break;
				default:
					Llvm_lifetime_start_p0.Invoke(24L, &llvm_libc_20_1_2_scanf_core_ReadBuffer);
					*(IntPtr*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer) = unchecked((nint)(-6148914691236517206L));
					((long*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer))[1] = -6148914691236517206L;
					((long*)(&llvm_libc_20_1_2_scanf_core_ReadBuffer))[2] = -6148914691236517206L;
					ArrayGenericSize_Constructor.Invoke(&llvm_libc_20_1_2_scanf_core_ReadBuffer, Array, Array_len, Elem_size);
					Internal_quick_sort_internal_ArrayGenericSize_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(&llvm_libc_20_1_2_scanf_core_ReadBuffer, Is_less);
					Llvm_lifetime_end_p0.Invoke(24L, &llvm_libc_20_1_2_scanf_core_ReadBuffer);
					break;
				}
			}
		}
	}
}
