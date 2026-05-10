using System;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class qsort
{
	public unsafe static void Invoke(void* array, long array_size, long elem_size, void* compare)
	{
		anon_589mcc anon_589mcc2 = default(anon_589mcc);
		llvm_lifetime_start_p0.Invoke(8L, &anon_589mcc2);
		*unchecked((IntPtr*)(&anon_589mcc2)) = unchecked((nint)(-6148914691236517206L));
		anon_589mcc2.field_0 = compare;
		void_internal_unstable_sort_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_void_unsigned_long_unsigned_long_qsort_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_0_const.Invoke(array, array_size, elem_size, &anon_589mcc2);
		llvm_lifetime_end_p0.Invoke(8L, &anon_589mcc2);
	}
}
