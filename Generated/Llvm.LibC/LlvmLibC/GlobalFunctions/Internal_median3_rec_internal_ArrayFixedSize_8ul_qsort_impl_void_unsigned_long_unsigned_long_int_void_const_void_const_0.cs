using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_median3_rec_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal11median3_recINS0_14ArrayFixedSizeILm8EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEmRKT_mmmmRKT0_")]
	[DemangledName("unsigned long __llvm_libc_20_1_2_::internal::median3_rec<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&, unsigned long, unsigned long, unsigned long, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)")]
	[return: NativeType("unsigned long")]
	public unsafe static long Invoke([MangledName("array")][NativeType("__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul> const&")] void* Array, [MangledName("a")][NativeType("unsigned long")] long A, [MangledName("b")][NativeType("unsigned long")] long B, [MangledName("c")][NativeType("unsigned long")] long C, [MangledName("n")][NativeType("unsigned long")] long N, [MangledName("is_less")][NativeType("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&")] void* Is_less)
	{
		long num = 0L;
		long num2 = A;
		long num3 = B;
		long num4 = C;
		unchecked
		{
			if ((ulong)(N * 8L) >= 64uL)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num);
				num = (long)((ulong)N / 8uL);
				num2 = Invoke(Array, num2, num2 + num * 4L, num2 + num * 7L, num, Is_less);
				num3 = Invoke(Array, num3, num3 + num * 4L, num3 + num * 7L, num, Is_less);
				num4 = Invoke(Array, num4, num4 + num * 4L, num4 + num * 7L, num, Is_less);
				Llvm_lifetime_end_p0.Invoke(8L, &num);
			}
			return Internal_median3_internal_ArrayFixedSize_8ul_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, num2, num3, num4, Is_less);
		}
	}
}
