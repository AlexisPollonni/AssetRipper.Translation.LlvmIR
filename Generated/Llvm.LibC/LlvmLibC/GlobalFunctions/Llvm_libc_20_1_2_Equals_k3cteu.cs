using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Llvm_libc_20_1_2_Equals_k3cteu
{
	[MangledName("_ZN19__llvm_libc_20_1_2_eqERKNS_6BigIntILm256ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator==(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
	[CleanName("Llvm_libc_20_1_2_Equals")]
	public unsafe static bool Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_x9dsed* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&")] Llvm_libc_20_1_2_BigInt_x9dsed* Rhs)
	{
		bool result = false;
		long num = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num2;
			while (true)
			{
				if ((ulong)num >= 4uL)
				{
					num2 = 2;
					break;
				}
				if (*(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(&Lhs->Val, num) != *(long*)Array_unsigned_long_4ul_Index_pwcpnu.Invoke(&Rhs->Val, num))
				{
					result = false;
					num2 = 1;
					break;
				}
				num++;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
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
