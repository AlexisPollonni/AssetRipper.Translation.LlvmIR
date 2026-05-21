using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class lambda_Invoke_yvgr8t
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_14ArrayFixedSizeILm4EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEvRT_S6_mRKT0_ENKUlS6_S6_E_clES6_S6_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<4ul>&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)::'lambda'(void const*, void const*)::operator()(void const*, void const*) const")]
	[CleanName("lambda_Invoke")]
	[return: NativeType("void")]
	public unsafe static bool Invoke(void* @this, [NativeType("void const*")] void* a, [NativeType("void const*")] void* b)
	{
		return unchecked((byte)((_0_Invoke_4rap2e.Invoke(&((anon_7y5tgm*)@this)->field_0, b, a) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
