using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_left_shift
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal10left_shiftEj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::left_shift(unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] Internal_HighPrecisionDecimal* This, [MangledName("shift_amount")][NativeType("unsigned int")] int Shift_amount)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = HighPrecisionDecimal_get_num_new_digits.Invoke(This, Shift_amount);
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = This->Num_digits - 1;
			Llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = This->Num_digits + num;
			Llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = 0L;
			while (num2 >= 0)
			{
				long num9 = (long)((ulong)(byte)((sbyte*)(&This->Digits))[num2] << (int)(uint)Shift_amount);
				num4 += num9;
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = (long)((ulong)num4 / 10uL);
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = num4 - 10L * num5;
				num3 += -1;
				if ((uint)num3 < 800u)
				{
					((sbyte*)(&This->Digits))[(uint)num3] = (sbyte)num6;
				}
				else if (num6 != 0L)
				{
					This->Truncated = 1;
				}
				num4 = num5;
				num2 = checked(num2 + -1);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
			}
			while ((ulong)num4 > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = (long)((ulong)num4 / 10uL);
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = num4 - 10L * num7;
				num3 += -1;
				if ((uint)num3 < 800u)
				{
					((sbyte*)(&This->Digits))[(uint)num3] = (sbyte)num8;
				}
				else if (num8 != 0L)
				{
					This->Truncated = 1;
				}
				num4 = num7;
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
			}
			This->Num_digits += num;
			if ((uint)This->Num_digits > 800u)
			{
				This->Num_digits = 800;
			}
			This->Decimal_point += num;
			HighPrecisionDecimal_trim_trailing_zeroes.Invoke(This);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(4L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
