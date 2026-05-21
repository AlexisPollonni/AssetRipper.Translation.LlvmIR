using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_hxaia2
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_16ArrayGenericSizeEZNS_16__qsort_r_impl__EPvmmPFiPKvS5_S3_ES3_E3$_0EEvRT_S5_mRKT0_ENKUlS5_S5_E_clES5_S5_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayGenericSize, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0>(__llvm_libc_20_1_2_::internal::ArrayGenericSize&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0 const&)::'lambda'(void const*, void const*)::operator()(void const*, void const*) const")]
	[CleanName("lambda_Invoke")]
	[return: NativeType("void")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const*")] void* a, [NativeType("void const*")] void* b)
	{
		return unchecked((byte)((_0_Invoke_kq6gnz.Invoke(&((anon_e6q534*)@this)->field_0, b, a) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
