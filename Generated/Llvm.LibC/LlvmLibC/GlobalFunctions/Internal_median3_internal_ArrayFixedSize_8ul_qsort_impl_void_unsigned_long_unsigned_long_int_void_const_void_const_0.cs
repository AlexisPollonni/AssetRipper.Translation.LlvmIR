using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_median3_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal7median3INS0_14ArrayFixedSizeILm8EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEmRKT_mmmRKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::median3<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, unsigned long, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&")] void* Array, [MangledName("a")][NativeType("unsigned long")] long A, [MangledName("b")][NativeType("unsigned long")] long B, [MangledName("c")][NativeType("unsigned long")] long C, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		void* a = null;
		void* ptr = null;
		void* b = null;
		sbyte b2 = 0;
		sbyte b3 = 0;
		sbyte b4 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &a);
		a = ArrayFixedSize_8ul_get.Invoke(Array, A);
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		ptr = ArrayFixedSize_8ul_get.Invoke(Array, B);
		Llvm_lifetime_start_p0.Invoke(8L, &b);
		b = ArrayFixedSize_8ul_get.Invoke(Array, C);
		Llvm_lifetime_start_p0.Invoke(1L, &b2);
		b2 = (_0_Invoke_4rap2e.Invoke(Is_less, a, ptr) ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(1L, &b3);
		b3 = (_0_Invoke_4rap2e.Invoke(Is_less, a, b) ? ((sbyte)1) : ((sbyte)0));
		long result;
		if ((b2 & 1) == 1 == ((b3 & 1) == 1))
		{
			Llvm_lifetime_start_p0.Invoke(1L, &b4);
			b4 = (_0_Invoke_4rap2e.Invoke(Is_less, ptr, b) ? ((sbyte)1) : ((sbyte)0));
			result = ((!(((b4 & 1) == 1) ^ ((b2 & 1) == 1))) ? B : C);
			Llvm_lifetime_end_p0.Invoke(1L, &b4);
		}
		else
		{
			result = A;
		}
		Llvm_lifetime_end_p0.Invoke(1L, &b3);
		Llvm_lifetime_end_p0.Invoke(1L, &b2);
		Llvm_lifetime_end_p0.Invoke(8L, &b);
		Llvm_lifetime_end_p0.Invoke(8L, &ptr);
		Llvm_lifetime_end_p0.Invoke(8L, &a);
		return result;
	}
}
