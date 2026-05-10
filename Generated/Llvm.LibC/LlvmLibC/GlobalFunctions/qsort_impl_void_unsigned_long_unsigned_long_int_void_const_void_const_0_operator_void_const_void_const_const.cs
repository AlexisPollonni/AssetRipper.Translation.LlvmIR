using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_14__qsort_impl__EPvmmPFiPKvS2_EENK3$_0clES2_S2_")]
[DemangledName("__llvm_libc_20_1_2_::__qsort_impl__(void*, unsigned long, unsigned long, int (*)(void const*, void const*))::$_0::operator()(void const*, void const*) const")]
internal static partial class qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_operator_void_const_void_const_const
{
	public unsafe static bool Invoke(void* @this, void* a, void* b)
	{
		return unchecked((delegate*<void*, void*, int>)((anon_589mcc*)@this)->field_0)(a, b) < 0;
	}
}
