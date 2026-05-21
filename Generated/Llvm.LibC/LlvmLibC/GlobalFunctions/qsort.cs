using System;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class qsort
{
	public unsafe static void Invoke(void* array, long array_size, long elem_size, void* compare)
	{
		anon_5uk363 anon_5uk364 = default(anon_5uk363);
		llvm_lifetime_start_p0.Invoke(8L, &anon_5uk364);
		*unchecked((IntPtr*)(&anon_5uk364)) = unchecked((nint)(-6148914691236517206L));
		anon_5uk364.field_0 = compare;
		internal_unstable_sort_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0.Invoke(array, array_size, elem_size, &anon_5uk364);
		llvm_lifetime_end_p0.Invoke(8L, &anon_5uk364);
	}
}
