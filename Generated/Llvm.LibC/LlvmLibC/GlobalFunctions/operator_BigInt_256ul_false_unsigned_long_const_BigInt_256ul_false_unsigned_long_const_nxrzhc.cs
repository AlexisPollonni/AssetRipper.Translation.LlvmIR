using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_eqERKNS_6BigIntILm256ELb0EmEES3_")]
[DemangledName("__llvm_libc_20_1_2_::operator==(__llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&, __llvm_libc_20_1_2_::BigInt<256ul, false, unsigned long> const&)")]
[CleanName("operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const")]
internal static partial class operator_BigInt_256ul_false_unsigned_long_const_BigInt_256ul_false_unsigned_long_const_nxrzhc
{
	public unsafe static bool Invoke(BigInt_x9dsed* lhs, BigInt_x9dsed* rhs)
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
				if ((ulong)num >= 4uL)
				{
					num2 = 2;
					break;
				}
				if (*(long*)cpp_array_unsigned_long_4ul_operator_unsigned_long_const.Invoke(&lhs->val, num) != *(long*)cpp_array_unsigned_long_4ul_operator_unsigned_long_const.Invoke(&rhs->val, num))
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
