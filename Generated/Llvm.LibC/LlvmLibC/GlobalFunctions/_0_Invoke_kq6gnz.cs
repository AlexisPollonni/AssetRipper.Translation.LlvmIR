using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class _0_Invoke_kq6gnz
{
	[MangledName("_ZZN19__llvm_libc_20_1_2_16__qsort_r_impl__EPvmmPFiPKvS2_S0_ES0_ENK3$_0clES2_S2_")]
	[DemangledName("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0::operator()(void const*, void const*) const")]
	[CleanName("_0_Invoke")]
	public unsafe static bool Invoke([MangledName("this")] void* This, [MangledName("a")][NativeType("void const*")] void* A, [MangledName("b")][NativeType("void const*")] void* B)
	{
		return unchecked(((delegate*<void*, void*, void*, int>)((Anon_6je4un*)This)->field_0)(A, B, ((Anon_6je4un*)This)->field_1)) < 0;
	}
}
