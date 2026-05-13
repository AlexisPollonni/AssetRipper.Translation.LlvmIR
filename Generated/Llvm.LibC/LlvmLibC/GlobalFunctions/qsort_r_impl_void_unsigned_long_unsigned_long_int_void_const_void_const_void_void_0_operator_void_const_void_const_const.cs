using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_16__qsort_r_impl__EPvmmPFiPKvS2_S0_ES0_ENK3$_0clES2_S2_")]
[DemangledName("__llvm_libc_20_1_2_::__qsort_r_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*, void*), void*)::$_0::operator()(void const*, void const*) const")]
internal static partial class qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_operator_void_const_void_const_const
{
	public unsafe static bool Invoke(void* @this, void* a, void* b)
	{
		return unchecked(((delegate*<void*, void*, void*, int>)((anon_6je4un*)@this)->field_0)(a, b, ((anon_6je4un*)@this)->field_1)) < 0;
	}
}
