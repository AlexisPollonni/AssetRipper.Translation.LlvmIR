using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Equals_s36iku
{
	[MangledName("_ZN19__llvm_libc_20_1_2_eqERKNS_6BigIntILm128ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator==(__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&)")]
	[CleanName("Equals")]
	public unsafe static bool Invoke([NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* lhs, [NativeType("__llvm_libc_20_1_2_::BigInt<128ul, false, unsigned long> const&")] anon_izyfb7* rhs)
	{
		bool result = false;
		long num = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num2;
			while (true)
			{
				if ((ulong)num >= 2uL)
				{
					num2 = 2;
					break;
				}
				if (*(long*)array_unsigned_long_2ul_Index_j6w6uu.Invoke(&((BigInt_qdkjbh*)lhs)->val, num) != *(long*)array_unsigned_long_2ul_Index_j6w6uu.Invoke(&((BigInt_qdkjbh*)rhs)->val, num))
				{
					result = false;
					num2 = 1;
					break;
				}
				num++;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			int num3 = num2;
			if (num3 != 2)
			{
				if (num3 != 1)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
			}
			else
			{
				result = true;
			}
			return result;
		}
	}
}
