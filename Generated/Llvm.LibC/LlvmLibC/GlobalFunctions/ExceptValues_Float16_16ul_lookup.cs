using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ExceptValues_Float16_16ul_lookup
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm16EE6lookupEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<_Float16, 16ul>::lookup(unsigned short) const")]
	public unsafe static int Invoke(fputil_ExceptValues_2ypjej* @this, [NativeType("unsigned short")] short x_bits)
	{
		cpp_optional_aq7wey cpp_optional_aq7wey2 = default(cpp_optional_aq7wey);
		long num = 0L;
		short num2 = 0;
		Half half = default(Half);
		fputil_FPBits_2fahva fputil_FPBits_2fahva2 = default(fputil_FPBits_2fahva);
		short num3 = x_bits;
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num4;
			while (true)
			{
				if ((ulong)num >= 16uL)
				{
					num4 = 2;
					break;
				}
				if (details_expects_bool_condition_bool.Invoke((ushort)num3 == (ushort)((fputil_ExceptValues_Float16_21_Mapping*)(&@this->values))[num].input, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = ((fputil_ExceptValues_Float16_21_Mapping*)(&@this->values))[num].rnd_towardzero_result;
					switch (fputil_quick_get_round.Invoke())
					{
					case 2048:
					{
						int num7 = (ushort)((fputil_ExceptValues_Float16_21_Mapping*)(&@this->values))[num].rnd_upward_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num7);
						break;
					}
					case 1024:
					{
						int num6 = (ushort)((fputil_ExceptValues_Float16_21_Mapping*)(&@this->values))[num].rnd_downward_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num6);
						break;
					}
					case 0:
					{
						int num5 = (ushort)((fputil_ExceptValues_Float16_21_Mapping*)(&@this->values))[num].rnd_tonearest_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num5);
						break;
					}
					}
					llvm_lifetime_start_p0.Invoke(2L, &half);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva2, num2);
					half = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva2);
					optional_Float16_Constructor.Invoke(&cpp_optional_aq7wey2, &half);
					llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					llvm_lifetime_end_p0.Invoke(2L, &half);
					num4 = 1;
					llvm_lifetime_end_p0.Invoke(2L, &num2);
					break;
				}
				num++;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			int num8 = num4;
			if (num8 != 2)
			{
				if (num8 != 1)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
			}
			else
			{
				optional_Float16_Constructor.Invoke(&cpp_optional_aq7wey2);
			}
			return *(int*)(&cpp_optional_aq7wey2.storage);
		}
	}
}
