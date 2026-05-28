using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Equals_tpd9hp
{
	[MangledName("_ZN19__llvm_libc_20_1_2_eqERKNS_6BigIntILm64ELb0EmEES3_")]
	[DemangledName("__llvm_libc_20_1_2_::operator==(__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&)")]
	[CleanName("Equals")]
	public unsafe static bool Invoke([MangledName("lhs")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Lhs, [MangledName("rhs")][NativeType("__llvm_libc_20_1_2_::BigInt<64ul, false, unsigned long> const&")] BigInt_555ggs* Rhs)
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
				if ((ulong)num >= 1uL)
				{
					num2 = 2;
					break;
				}
				if (*(long*)Array_unsigned_long_1ul_Index_fk3nam.Invoke(&Lhs->Val, num) != *(long*)Array_unsigned_long_1ul_Index_fk3nam.Invoke(&Rhs->Val, num))
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
