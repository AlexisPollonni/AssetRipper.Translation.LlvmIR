using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class internal_median3_internal_ArrayGenericSize_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7median3INS0_16ArrayGenericSizeEZNS_16__qsort_r_impl__EPvmmPFiPKvS5_S3_ES3_E3$_0EEmRKT_mmmRKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::median3<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize const&, unsigned long, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([NativeType("__llvm_libc_20_1_2_::internal::ArrayGenericSize const&")] void* array, [NativeType("unsigned long")] long a, [NativeType("unsigned long")] long b, [NativeType("unsigned long")] long c, [NativeType("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&")] void* is_less)
	{
		void* a2 = null;
		void* ptr = null;
		void* b2 = null;
		sbyte b3 = 0;
		sbyte b4 = 0;
		sbyte b5 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &a2);
		a2 = ArrayGenericSize_get.Invoke(array, a);
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = ArrayGenericSize_get.Invoke(array, b);
		llvm_lifetime_start_p0.Invoke(8L, &b2);
		b2 = ArrayGenericSize_get.Invoke(array, c);
		llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = (_0_Invoke_kq6gnz.Invoke(is_less, a2, ptr) ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(1L, &b4);
		b4 = (_0_Invoke_kq6gnz.Invoke(is_less, a2, b2) ? ((sbyte)1) : ((sbyte)0));
		long result;
		if ((b3 & 1) == 1 == ((b4 & 1) == 1))
		{
			llvm_lifetime_start_p0.Invoke(1L, &b5);
			b5 = (_0_Invoke_kq6gnz.Invoke(is_less, ptr, b2) ? ((sbyte)1) : ((sbyte)0));
			result = ((!(((b5 & 1) == 1) ^ ((b3 & 1) == 1))) ? b : c);
			llvm_lifetime_end_p0.Invoke(1L, &b5);
		}
		else
		{
			result = a;
		}
		llvm_lifetime_end_p0.Invoke(1L, &b4);
		llvm_lifetime_end_p0.Invoke(1L, &b3);
		llvm_lifetime_end_p0.Invoke(8L, &b2);
		llvm_lifetime_end_p0.Invoke(8L, &ptr);
		llvm_lifetime_end_p0.Invoke(8L, &a2);
		return result;
	}
}
