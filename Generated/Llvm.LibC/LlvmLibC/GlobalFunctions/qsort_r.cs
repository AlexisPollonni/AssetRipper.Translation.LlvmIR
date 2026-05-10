using System;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class qsort_r
{
	public unsafe static void Invoke(void* array, long array_size, long elem_size, void* compare, void* arg)
	{
		anon_6je4un anon_6je4un2 = default(anon_6je4un);
		llvm_lifetime_start_p0.Invoke(16L, &anon_6je4un2);
		unchecked
		{
			*(IntPtr*)(&anon_6je4un2) = unchecked((nint)(-6148914691236517206L));
			*(IntPtr*)((byte*)(&anon_6je4un2) + 8) = unchecked((nint)(-6148914691236517206L));
			anon_6je4un2.field_0 = compare;
			anon_6je4un2.field_1 = arg;
			void_internal_unstable_sort_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_void_unsigned_long_unsigned_long_qsort_r_impl_void_unsigned_long_unsigned_long_int_void_const_void_const_void_void_0_const.Invoke(array, array_size, elem_size, &anon_6je4un2);
			llvm_lifetime_end_p0.Invoke(16L, &anon_6je4un2);
		}
	}
}
