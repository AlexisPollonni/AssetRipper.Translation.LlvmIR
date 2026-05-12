using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_14inline_strncmpIRZNS_20__strncasecmp_impl__EPKcS2_mE3$_0EEiS2_S2_mOT_")]
[DemangledName("int __llvm_libc_20_1_2_::inline_strncmp<__llvm_libc_20_1_2_::__strncasecmp_impl__(char const*, char const*, unsigned long)::$_0&>(char const*, char const*, unsigned long, __llvm_libc_20_1_2_::__strncasecmp_impl__(char const*, char const*, unsigned long)::$_0&)")]
internal static partial class int_inline_strncmp_strncasecmp_impl_char_const_char_const_unsigned_long_0_char_const_char_const_unsigned_long_strncasecmp_impl_char_const_char_const_unsigned_long_0
{
	public unsafe static int Invoke(void* left, void* right, long n, void* comp)
	{
		sbyte a = 0;
		void* ptr = left;
		void* ptr2 = right;
		long num = n;
		if (num == 0L)
		{
			return 0;
		}
		unchecked
		{
			for (; (ulong)num > 1uL; num += -1L, ptr = (byte*)ptr + 1, ptr2 = (byte*)ptr2 + 1)
			{
				llvm_lifetime_start_p0.Invoke(1L, &a);
				a = *(sbyte*)ptr;
				int num2 = ((strncasecmp_impl_char_const_char_const_unsigned_long_0_operator_char_char_const.Invoke(comp, a, 0) == 0 || strncasecmp_impl_char_const_char_const_unsigned_long_0_operator_char_char_const.Invoke(comp, a, *(sbyte*)ptr2) != 0) ? 2 : 0);
				llvm_lifetime_end_p0.Invoke(1L, &a);
				switch (num2)
				{
				case 0:
					continue;
				case 2:
					break;
				default:
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
				break;
			}
			return strncasecmp_impl_char_const_char_const_unsigned_long_0_operator_char_char_const.Invoke(comp, *(sbyte*)ptr, *(sbyte*)ptr2);
		}
	}
}
