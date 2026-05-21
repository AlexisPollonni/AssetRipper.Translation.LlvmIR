using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ExceptValues_Float16_9ul_lookup_odd
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil12ExceptValuesIDF16_Lm9EE10lookup_oddEtb")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<_Float16, 9ul>::lookup_odd(unsigned short, bool) const")]
	public unsafe static int Invoke([MangledName("this")] Llvm_libc_20_1_2_fputil_ExceptValues_fkx7qf* This, [MangledName("x_abs")][NativeType("unsigned short")] short X_abs, [MangledName("sign")][NativeType("bool")] bool Sign)
	{
		Llvm_libc_20_1_2_cpp_optional_aq7wey llvm_libc_20_1_2_cpp_optional_aq7wey = default(Llvm_libc_20_1_2_cpp_optional_aq7wey);
		long num = 0L;
		short num2 = 0;
		Half half = default(Half);
		Llvm_libc_20_1_2_fputil_FPBits_2fahva llvm_libc_20_1_2_fputil_FPBits_2fahva = default(Llvm_libc_20_1_2_fputil_FPBits_2fahva);
		short num3 = X_abs;
		sbyte b = (Sign ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num4;
			while (true)
			{
				if ((ulong)num >= 9uL)
				{
					num4 = 2;
					break;
				}
				if (Details_expects_bool_condition_bool.Invoke((ushort)num3 == (ushort)((Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Input, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(2L, &num2);
					num2 = ((Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_towardzero_result;
					switch (Fputil_quick_get_round.Invoke())
					{
					case 2048:
						if ((b & 1) == 1)
						{
							int num8 = (ushort)((Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_downward_offset;
							num2 = (short)checked(unchecked((ushort)num2) + num8);
						}
						else
						{
							int num9 = (ushort)((Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_upward_offset;
							num2 = (short)checked(unchecked((ushort)num2) + num9);
						}
						break;
					case 1024:
						if ((b & 1) == 1)
						{
							int num6 = (ushort)((Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_upward_offset;
							num2 = (short)checked(unchecked((ushort)num2) + num6);
						}
						else
						{
							int num7 = (ushort)((Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_downward_offset;
							num2 = (short)checked(unchecked((ushort)num2) + num7);
						}
						break;
					case 0:
					{
						int num5 = (ushort)((Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping*)(&This->Values))[num].Rnd_tonearest_offset;
						num2 = (short)checked(unchecked((ushort)num2) + num5);
						break;
					}
					}
					Llvm_lifetime_start_p0.Invoke(2L, &half);
					Llvm_lifetime_start_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					FPBits_Float16_FPBits_unsigned_short.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva, num2);
					Half half2 = FPBits_Float16_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_2fahva);
					Llvm_lifetime_end_p0.Invoke(2L, &llvm_libc_20_1_2_fputil_FPBits_2fahva);
					half = half2;
					if ((b & 1) == 1)
					{
						half = (Half)(0f - (float)half);
					}
					Optional_Float16_Constructor.Invoke(&llvm_libc_20_1_2_cpp_optional_aq7wey, &half);
					num4 = 1;
					Llvm_lifetime_end_p0.Invoke(2L, &half);
					Llvm_lifetime_end_p0.Invoke(2L, &num2);
					break;
				}
				num++;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			int num10 = num4;
			if (num10 != 2)
			{
				if (num10 != 1)
				{
					throw new NotImplementedException("Reached LLVM unreachable instruction.");
				}
			}
			else
			{
				Optional_Float16_Constructor.Invoke(&llvm_libc_20_1_2_cpp_optional_aq7wey);
			}
			return *(int*)(&llvm_libc_20_1_2_cpp_optional_aq7wey.Storage);
		}
	}
}
