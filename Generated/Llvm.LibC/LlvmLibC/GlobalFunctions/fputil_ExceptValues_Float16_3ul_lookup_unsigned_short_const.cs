using System;
using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm3EE6lookupEt")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<_Float16, 3ul>::lookup(unsigned short) const")]
internal static partial class fputil_ExceptValues_Float16_3ul_lookup_unsigned_short_const
{
	public unsafe static int Invoke(void* @this, short x_bits)
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
				if ((ulong)num >= 3uL)
				{
					num4 = 2;
					break;
				}
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke((ushort)num3 == (ushort)((fputil_ExceptValues_Float16_21_Mapping*)(&((fputil_ExceptValues_uk6z3c*)@this)->values))[num].input, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = ((fputil_ExceptValues_Float16_21_Mapping*)(&((fputil_ExceptValues_uk6z3c*)@this)->values))[num].rnd_towardzero_result;
					switch (fputil_quick_get_round.Invoke())
					{
					case 2048:
					{
						int num7 = (ushort)((fputil_ExceptValues_Float16_21_Mapping*)(&((fputil_ExceptValues_uk6z3c*)@this)->values))[num].rnd_upward_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num7);
						break;
					}
					case 1024:
					{
						int num6 = (ushort)((fputil_ExceptValues_Float16_21_Mapping*)(&((fputil_ExceptValues_uk6z3c*)@this)->values))[num].rnd_downward_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num6);
						break;
					}
					case 0:
					{
						int num5 = (ushort)((fputil_ExceptValues_Float16_21_Mapping*)(&((fputil_ExceptValues_uk6z3c*)@this)->values))[num].rnd_tonearest_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num5);
						break;
					}
					}
					llvm_lifetime_start_p0.Invoke(2L, &half);
					llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva2);
					fputil_FPBits_Float16_FPBits_unsigned_short_unsigned_short.Invoke(&fputil_FPBits_2fahva2, num2);
					half = fputil_FPBits_Float16_get_val_const.Invoke(&fputil_FPBits_2fahva2);
					cpp_optional_Float16_optional_Float16.Invoke(&cpp_optional_aq7wey2, &half);
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
					throw null;
				}
			}
			else
			{
				cpp_optional_Float16_optional_cpp_nullopt_t.Invoke(&cpp_optional_aq7wey2);
			}
			return *(int*)(&cpp_optional_aq7wey2.storage);
		}
	}
}
