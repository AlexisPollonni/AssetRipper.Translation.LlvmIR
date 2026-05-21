using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class inline_strncmp_strncmp_impl_char_const_char_const_unsigned_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14inline_strncmpIRZNS_16__strncmp_impl__EPKcS2_mE3$_0EEiS2_S2_mOT_")]
	[DemangledName("int __llvm_libc_20_1_2_::inline_strncmp<__llvm_libc_20_1_2_::__strncmp_impl__(char const*, char const*, unsigned long)::$_0&>(char const*, char const*, unsigned long, __llvm_libc_20_1_2_::__strncmp_impl__(char const*, char const*, unsigned long)::$_0&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([NativeType("char const*")] void* left, [NativeType("char const*")] void* right, [NativeType("unsigned long")] long n, [NativeType("__llvm_libc_20_1_2_::__strncmp_impl__(char const*, char const*, unsigned long)::$_0&")] void* comp)
	{
		sbyte l = 0;
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
				llvm_lifetime_start_p0.Invoke(1L, &l);
				l = *(sbyte*)ptr;
				int num2 = ((_0_Invoke_9mb5ym.Invoke(comp, l, 0) == 0 || _0_Invoke_9mb5ym.Invoke(comp, l, *(sbyte*)ptr2) != 0) ? 2 : 0);
				llvm_lifetime_end_p0.Invoke(1L, &l);
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
			return _0_Invoke_9mb5ym.Invoke(comp, *(sbyte*)ptr, *(sbyte*)ptr2);
		}
	}
}
