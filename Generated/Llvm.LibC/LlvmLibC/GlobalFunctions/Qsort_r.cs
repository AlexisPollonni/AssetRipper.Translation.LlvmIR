using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Qsort_r
{
	[MangledName("qsort_r")]
	[DemangledName("qsort_r")]
	public unsafe static void Invoke([MangledName("array")] void* Array, [MangledName("array_size")] long Array_size, [MangledName("elem_size")] long Elem_size, [MangledName("compare")] void* Compare, [MangledName("arg")] void* Arg)
	{
		Anon_6je4un anon_6je4un = default(Anon_6je4un);
		Llvm_lifetime_start_p0.Invoke(16L, &anon_6je4un);
		unchecked
		{
			*(IntPtr*)(&anon_6je4un) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)(&anon_6je4un) + 8) = unchecked((nint)(-6148914691236517206L));
			anon_6je4un.field_0 = Compare;
			anon_6je4un.field_1 = Arg;
			Internal_unstable_sort_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0.Invoke(Array, Array_size, Elem_size, &anon_6je4un);
			Llvm_lifetime_end_p0.Invoke(16L, &anon_6je4un);
		}
	}
}
