using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_inline_strncmp_strncasecmp_impl_char_const_char_const_unsigned_long_0
{
	[MangledName("_ZN19__llvm_libc_20_1_2_14inline_strncmpIRZNS_20__strncasecmp_impl__EPKcS2_mE3$_0EEiS2_S2_mOT_")]
	[DemangledName("int __llvm_libc_20_1_2_::inline_strncmp<__llvm_libc_20_1_2_::__strncasecmp_impl__(char const*, char const*, unsigned long)::$_0&>(char const*, char const*, unsigned long, __llvm_libc_20_1_2_::__strncasecmp_impl__(char const*, char const*, unsigned long)::$_0&)")]
	[return: NativeType("int")]
	public unsafe static int Invoke([MangledName("left")][NativeType("char const*")] void* Left, [MangledName("right")][NativeType("char const*")] void* Right, [MangledName("n")][NativeType("unsigned long")] long N, [MangledName("comp")][NativeType("__llvm_libc_20_1_2_::__strncasecmp_impl__(char const*, char const*, unsigned long)::$_0&")] void* Comp)
	{
		sbyte a = 0;
		void* ptr = Left;
		void* ptr2 = Right;
		long num = N;
		if (num == 0L)
		{
			return 0;
		}
		unchecked
		{
			for (; (ulong)num > 1uL; num += -1L, ptr = (byte*)ptr + 1, ptr2 = (byte*)ptr2 + 1)
			{
				Llvm_lifetime_start_p0.Invoke(1L, &a);
				a = *(sbyte*)ptr;
				int num2 = ((_0_Invoke_paa5ka.Invoke(Comp, a, 0) == 0 || _0_Invoke_paa5ka.Invoke(Comp, a, *(sbyte*)ptr2) != 0) ? 2 : 0);
				Llvm_lifetime_end_p0.Invoke(1L, &a);
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
			return _0_Invoke_paa5ka.Invoke(Comp, *(sbyte*)ptr, *(sbyte*)ptr2);
		}
	}
}
