using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ExceptValues_Float16_4ul_lookup
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm4EE6lookupEt")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<_Float16, 4ul>::lookup(unsigned short) const")]
	public unsafe static int Invoke([MangledName("this")] Fputil_ExceptValues_pfsijn* This, [MangledName("x_bits")][NativeType("unsigned short")] short X_bits)
	{
		Cpp_optional_aq7wey cpp_optional_aq7wey = default(Cpp_optional_aq7wey);
		long num = 0L;
		short num2 = 0;
		Half half = default(Half);
		Fputil_FPBits_2fahva fputil_FPBits_2fahva = default(Fputil_FPBits_2fahva);
		short num3 = X_bits;
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num4;
			while (true)
			{
				if ((ulong)num >= 4uL)
				{
					num4 = 2;
					break;
				}
				if (Details_expects_bool_condition_bool.Invoke((ushort)num3 == (ushort)((Fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Input, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = ((Fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_towardzero_result;
					switch (Fputil_quick_get_round.Invoke())
					{
					case 2048:
					{
						int num7 = (ushort)((Fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_upward_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num7);
						break;
					}
					case 1024:
					{
						int num6 = (ushort)((Fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_downward_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num6);
						break;
					}
					case 0:
					{
						int num5 = (ushort)((Fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_tonearest_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num5);
						break;
					}
					}
					Llvm_lifetime_start_p0.Invoke(2L, &half);
					Llvm_lifetime_start_p0.Invoke(2L, &fputil_FPBits_2fahva);
					FPBits_Float16_FPBits_unsigned_short.Invoke(&fputil_FPBits_2fahva, num2);
					half = FPBits_Float16_get_val.Invoke(&fputil_FPBits_2fahva);
					Optional_Float16_Constructor.Invoke(&cpp_optional_aq7wey, &half);
					Llvm_lifetime_end_p0.Invoke(2L, &fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(2L, &half);
					num4 = 1;
					Llvm_lifetime_end_p0.Invoke(2L, &num2);
					break;
				}
				num++;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
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
				Optional_Float16_Constructor.Invoke(&cpp_optional_aq7wey);
			}
			return *(int*)(&cpp_optional_aq7wey.Storage);
		}
	}
}
