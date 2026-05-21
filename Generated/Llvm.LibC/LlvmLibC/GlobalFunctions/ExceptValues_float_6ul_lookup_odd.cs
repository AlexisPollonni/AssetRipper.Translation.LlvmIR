using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ExceptValues_float_6ul_lookup_odd
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil12ExceptValuesIfLm6EE10lookup_oddEjb")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<float, 6ul>::lookup_odd(unsigned int, bool) const")]
	public unsafe static long Invoke(void* @this, [NativeType("unsigned int")] int x_abs, [NativeType("bool")] bool sign)
	{
		cpp_optional_xmxtsi cpp_optional_xmxtsi2 = default(cpp_optional_xmxtsi);
		long num = 0L;
		int num2 = 0;
		float num3 = 0f;
		fputil_FPBits_5nkvcs fputil_FPBits_5nkvcs2 = default(fputil_FPBits_5nkvcs);
		sbyte b = (sign ? ((sbyte)1) : ((sbyte)0));
		llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num4;
			while (true)
			{
				if ((ulong)num >= 6uL)
				{
					num4 = 2;
					break;
				}
				if (details_expects_bool_condition_bool.Invoke(x_abs == ((fputil_ExceptValues_float_6_Mapping*)(&((fputil_ExceptValues_7xi2jk*)@this)->values))[num].input, expected: false))
				{
					llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = ((fputil_ExceptValues_float_6_Mapping*)(&((fputil_ExceptValues_7xi2jk*)@this)->values))[num].rnd_towardzero_result;
					switch (fputil_quick_get_round.Invoke())
					{
					case 2048:
						if ((b & 1) == 1)
						{
							int rnd_downward_offset2 = ((fputil_ExceptValues_float_6_Mapping*)(&((fputil_ExceptValues_7xi2jk*)@this)->values))[num].rnd_downward_offset;
							num2 += rnd_downward_offset2;
						}
						else
						{
							int rnd_upward_offset2 = ((fputil_ExceptValues_float_6_Mapping*)(&((fputil_ExceptValues_7xi2jk*)@this)->values))[num].rnd_upward_offset;
							num2 += rnd_upward_offset2;
						}
						break;
					case 1024:
						if ((b & 1) == 1)
						{
							int rnd_upward_offset = ((fputil_ExceptValues_float_6_Mapping*)(&((fputil_ExceptValues_7xi2jk*)@this)->values))[num].rnd_upward_offset;
							num2 += rnd_upward_offset;
						}
						else
						{
							int rnd_downward_offset = ((fputil_ExceptValues_float_6_Mapping*)(&((fputil_ExceptValues_7xi2jk*)@this)->values))[num].rnd_downward_offset;
							num2 += rnd_downward_offset;
						}
						break;
					case 0:
					{
						int rnd_tonearest_offset = ((fputil_ExceptValues_float_6_Mapping*)(&((fputil_ExceptValues_7xi2jk*)@this)->values))[num].rnd_tonearest_offset;
						num2 += rnd_tonearest_offset;
						break;
					}
					}
					llvm_lifetime_start_p0.Invoke(4L, &num3);
					llvm_lifetime_start_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					FPBits_float_FPBits_unsigned_int.Invoke(&fputil_FPBits_5nkvcs2, num2);
					float num5 = FPBits_float_get_val.Invoke(&fputil_FPBits_5nkvcs2);
					llvm_lifetime_end_p0.Invoke(4L, &fputil_FPBits_5nkvcs2);
					num3 = num5;
					if ((b & 1) == 1)
					{
						num3 = 0f - num3;
					}
					optional_float_Constructor.Invoke(&cpp_optional_xmxtsi2, &num3);
					num4 = 1;
					llvm_lifetime_end_p0.Invoke(4L, &num3);
					llvm_lifetime_end_p0.Invoke(4L, &num2);
					break;
				}
				num++;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			int num6 = num4;
			if (num6 != 2)
			{
				if (num6 != 1)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
			}
			else
			{
				optional_float_Constructor.Invoke(&cpp_optional_xmxtsi2);
			}
			return *(long*)(&cpp_optional_xmxtsi2.storage);
		}
	}
}
