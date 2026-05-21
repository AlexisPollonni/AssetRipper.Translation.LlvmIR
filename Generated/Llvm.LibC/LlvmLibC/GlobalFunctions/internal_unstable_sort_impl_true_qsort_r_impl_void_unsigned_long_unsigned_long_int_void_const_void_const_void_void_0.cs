using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_unstable_sort_impl_true_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal18unstable_sort_implILb1EZNS_16__qsort_r_impl__EPvmmPFiPKvS4_S2_ES2_E3$_0EEvS2_mmRKT0_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::unstable_sort_impl<true, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(void*, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("void*")] void* array, [NativeType("unsigned long")] long array_len, [NativeType("unsigned long")] long elem_size, [NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* is_less)
	{
		cpp_string_view cpp_string_view2 = default(cpp_string_view);
		cpp_string_view cpp_string_view3 = default(cpp_string_view);
		cpp_string_view cpp_string_view4 = default(cpp_string_view);
		scanf_core_ReadBuffer scanf_core_ReadBuffer2 = default(scanf_core_ReadBuffer);
		unchecked
		{
			if (array != null && array_len != 0L && elem_size != 0L)
			{
				switch (elem_size)
				{
				case 4L:
					llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view2);
					*(IntPtr*)(&cpp_string_view2) = unchecked((nint)(-6148914691236517206L));
					((long*)(&cpp_string_view2))[1] = -6148914691236517206L;
					ArrayFixedSize_4ul_Constructor.Invoke(&cpp_string_view2, array, array_len);
					internal_quick_sort_internal_ArrayFixedSize_4ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(&cpp_string_view2, is_less);
					llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view2);
					break;
				case 8L:
					llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view3);
					*(IntPtr*)(&cpp_string_view3) = unchecked((nint)(-6148914691236517206L));
					((long*)(&cpp_string_view3))[1] = -6148914691236517206L;
					ArrayFixedSize_8ul_Constructor.Invoke(&cpp_string_view3, array, array_len);
					internal_quick_sort_internal_ArrayFixedSize_8ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(&cpp_string_view3, is_less);
					llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view3);
					break;
				case 16L:
					llvm_lifetime_start_p0.Invoke(16L, &cpp_string_view4);
					*(IntPtr*)(&cpp_string_view4) = unchecked((nint)(-6148914691236517206L));
					((long*)(&cpp_string_view4))[1] = -6148914691236517206L;
					ArrayFixedSize_16ul_Constructor.Invoke(&cpp_string_view4, array, array_len);
					internal_quick_sort_internal_ArrayFixedSize_16ul_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(&cpp_string_view4, is_less);
					llvm_lifetime_end_p0.Invoke(16L, &cpp_string_view4);
					break;
				default:
					llvm_lifetime_start_p0.Invoke(24L, &scanf_core_ReadBuffer2);
					*(IntPtr*)(&scanf_core_ReadBuffer2) = unchecked((nint)(-6148914691236517206L));
					((long*)(&scanf_core_ReadBuffer2))[1] = -6148914691236517206L;
					((long*)(&scanf_core_ReadBuffer2))[2] = -6148914691236517206L;
					ArrayGenericSize_Constructor.Invoke(&scanf_core_ReadBuffer2, array, array_len, elem_size);
					internal_quick_sort_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(&scanf_core_ReadBuffer2, is_less);
					llvm_lifetime_end_p0.Invoke(24L, &scanf_core_ReadBuffer2);
					break;
				}
			}
		}
	}
}
