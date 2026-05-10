using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL21strchr_implementationILb0EEEPcPKci")]
[DemangledName("char* __llvm_libc_20_1_2_::internal::strchr_implementation<false>(char const*, int)")]
internal static partial class char_internal_strchr_implementation_false_char_const_int
{
	public unsafe static void* Invoke(void* src, int c)
	{
		sbyte b = 0;
		void* ptr = null;
		void* ptr2 = src;
		llvm_lifetime_start_p0.Invoke(1L, &b);
		unchecked
		{
			for (b = (sbyte)c; *(bool*)ptr2 && *(sbyte*)ptr2 != b; ptr2 = (byte*)ptr2 + 1)
			{
			}
			llvm_lifetime_start_p0.Invoke(8L, &ptr);
			ptr = ptr2;
			void* result = ((*(sbyte*)ptr2 != b) ? ptr : ptr2);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			llvm_lifetime_end_p0.Invoke(1L, &b);
			return result;
		}
	}
}
