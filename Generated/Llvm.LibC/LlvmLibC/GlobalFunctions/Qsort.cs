using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Qsort
{
	[MangledName("qsort")]
	[DemangledName("qsort")]
	public unsafe static void Invoke([MangledName("array")] void* Array, [MangledName("array_size")] long Array_size, [MangledName("elem_size")] long Elem_size, [MangledName("compare")] void* Compare)
	{
		Anon_5uk363 anon_5uk = default(Anon_5uk363);
		Llvm_lifetime_start_p0.Invoke(8L, &anon_5uk);
		*unchecked((IntPtr*)(&anon_5uk)) = unchecked((nint)(-6148914691236517206L));
		anon_5uk.field_0 = Compare;
		Internal_unstable_sort_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(Array, Array_size, Elem_size, &anon_5uk);
		Llvm_lifetime_end_p0.Invoke(8L, &anon_5uk);
	}
}
