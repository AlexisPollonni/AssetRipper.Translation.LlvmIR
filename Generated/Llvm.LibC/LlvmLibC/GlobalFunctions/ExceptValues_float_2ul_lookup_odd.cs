using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class ExceptValues_float_2ul_lookup_odd
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_6fputil12ExceptValuesIfLm2EE10lookup_oddEjb")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::ExceptValues<float, 2ul>::lookup_odd(unsigned int, bool) const")]
	public unsafe static long Invoke([MangledName("this")] void* This, [MangledName("x_abs")][NativeType("unsigned int")] int X_abs, [MangledName("sign")][NativeType("bool")] bool Sign)
	{
		Llvm_libc_20_1_2_cpp_optional_xmxtsi llvm_libc_20_1_2_cpp_optional_xmxtsi = default(Llvm_libc_20_1_2_cpp_optional_xmxtsi);
		long num = 0L;
		int num2 = 0;
		float num3 = 0f;
		Llvm_libc_20_1_2_fputil_FPBits_5nkvcs llvm_libc_20_1_2_fputil_FPBits_5nkvcs = default(Llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
		sbyte b = (Sign ? ((sbyte)1) : ((sbyte)0));
		Llvm_lifetime_start_p0.Invoke(8L, &num);
		num = 0L;
		unchecked
		{
			int num4;
			while (true)
			{
				if ((ulong)num >= 2uL)
				{
					num4 = 2;
					break;
				}
				if (Details_expects_bool_condition_bool.Invoke(X_abs == ((Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping*)(&((Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6*)This)->Values))[num].Input, Expected: false))
				{
					Llvm_lifetime_start_p0.Invoke(4L, &num2);
					num2 = ((Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping*)(&((Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6*)This)->Values))[num].Rnd_towardzero_result;
					switch (Fputil_quick_get_round.Invoke())
					{
					case 2048:
						if ((b & 1) == 1)
						{
							int rnd_downward_offset2 = ((Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping*)(&((Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6*)This)->Values))[num].Rnd_downward_offset;
							num2 += rnd_downward_offset2;
						}
						else
						{
							int rnd_upward_offset2 = ((Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping*)(&((Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6*)This)->Values))[num].Rnd_upward_offset;
							num2 += rnd_upward_offset2;
						}
						break;
					case 1024:
						if ((b & 1) == 1)
						{
							int rnd_upward_offset = ((Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping*)(&((Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6*)This)->Values))[num].Rnd_upward_offset;
							num2 += rnd_upward_offset;
						}
						else
						{
							int rnd_downward_offset = ((Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping*)(&((Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6*)This)->Values))[num].Rnd_downward_offset;
							num2 += rnd_downward_offset;
						}
						break;
					case 0:
					{
						int rnd_tonearest_offset = ((Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping*)(&((Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6*)This)->Values))[num].Rnd_tonearest_offset;
						num2 += rnd_tonearest_offset;
						break;
					}
					}
					Llvm_lifetime_start_p0.Invoke(4L, &num3);
					Llvm_lifetime_start_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					FPBits_float_FPBits_unsigned_int.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs, num2);
					float num5 = FPBits_float_get_val.Invoke(&llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					Llvm_lifetime_end_p0.Invoke(4L, &llvm_libc_20_1_2_fputil_FPBits_5nkvcs);
					num3 = num5;
					if ((b & 1) == 1)
					{
						num3 = 0f - num3;
					}
					Optional_float_Constructor.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi, &num3);
					num4 = 1;
					Llvm_lifetime_end_p0.Invoke(4L, &num3);
					Llvm_lifetime_end_p0.Invoke(4L, &num2);
					break;
				}
				num++;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
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
				Optional_float_Constructor.Invoke(&llvm_libc_20_1_2_cpp_optional_xmxtsi);
			}
			return *(long*)(&llvm_libc_20_1_2_cpp_optional_xmxtsi.Storage);
		}
	}
}
