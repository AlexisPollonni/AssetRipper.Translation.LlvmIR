using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil12ExceptValuesIfLm19EE6lookupEj")]
[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<float, 19ul>::lookup(unsigned int) const")]
internal static partial class fputil_ExceptValues_float_19ul_lookup_unsigned_int_const
{
	public unsafe static long Invoke(fputil_ExceptValues_58kucm* @this, int x_bits)
	{
		cpp_optional_89h55j cpp_optional_89h55j2 = default(cpp_optional_89h55j);
		long num = 0L;
		int num2 = 0;
		float num3 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num4;
			while (true)
			{
				if ((ulong)num >= 19uL)
				{
					num4 = 2;
					break;
				}
				if (bool_details_expects_bool_condition_bool_bool_bool.Invoke(x_bits == ((fputil_ExceptValues_float_6_Mapping*)(&@this->values))[num].input, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = ((fputil_ExceptValues_float_6_Mapping*)(&@this->values))[num].rnd_towardzero_result;
					switch (fputil_quick_get_round.Invoke())
					{
					case 2048:
					{
						int rnd_upward_offset = ((fputil_ExceptValues_float_6_Mapping*)(&@this->values))[num].rnd_upward_offset;
						num2 += rnd_upward_offset;
						break;
					}
					case 1024:
					{
						int rnd_downward_offset = ((fputil_ExceptValues_float_6_Mapping*)(&@this->values))[num].rnd_downward_offset;
						num2 += rnd_downward_offset;
						break;
					}
					case 0:
					{
						int rnd_tonearest_offset = ((fputil_ExceptValues_float_6_Mapping*)(&@this->values))[num].rnd_tonearest_offset;
						num2 += rnd_tonearest_offset;
						break;
					}
					}
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					fputil_FPBits_float_FPBits_unsigned_int_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, num2);
					num3 = fputil_FPBits_float_get_val_const.Invoke(&fputil_FPBits_5nkvcs2);
					cpp_optional_float_optional_float.Invoke(&cpp_optional_89h55j2, &num3);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					num4 = 1;
					llvm_lifetime_end_p0.Invoke(4L, &num2);
					break;
				}
				num++;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			int num5 = num4;
			if (num5 != 2)
			{
				if (num5 != 1)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
			}
			else
			{
				cpp_optional_float_optional_cpp_nullopt_t.Invoke(&cpp_optional_89h55j2);
			}
			return *(long*)(&cpp_optional_89h55j2.storage);
		}
	}
}
