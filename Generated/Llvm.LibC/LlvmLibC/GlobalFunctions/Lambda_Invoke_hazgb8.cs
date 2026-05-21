using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Lambda_Invoke_hazgb8
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_8internal15quick_sort_implINS0_14ArrayFixedSizeILm8EEEZNS_14__qsort_impl__EPvmmPFiPKvS6_EE3$_0EEvRT_S6_mRKT0_ENKUlS6_S6_E_clES6_S6_")]
	[DemangledName("void __llvm_libc_20_1_2_::internal::quick_sort_impl<__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0>(__llvm_libc_20_1_2_::internal::ArrayFixedSize<8ul>&, void const*, unsigned long, __llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0 const&)::'lambda'(void const*, void const*)::operator()(void const*, void const*) const")]
	[CleanName("Lambda_Invoke")]
	[return: NativeType("void")]
	public unsafe static bool Invoke([MangledName("this")] void* This, [MangledName("a")][NativeType("void const*")] void* A, [MangledName("b")][NativeType("void const*")] void* B)
	{
		return unchecked((byte)((_0_Invoke_4rap2e.Invoke(&((Anon_7y5tgm*)This)->field_0, B, A) ? 1u : 0u) ^ 0xFFFFFFFFu)) != 0;
	}
}
