using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_right_shift
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal11right_shiftEj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::right_shift(unsigned int)")]
	public unsafe static void Invoke([MangledName("this")] Internal_HighPrecisionDecimal* This, [MangledName("shift_amount")][NativeType("unsigned int")] int Shift_amount)
	{
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		Llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		Llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 0L;
		Llvm_lifetime_start_p0.Invoke(8L, &num4);
		unchecked
		{
			num4 = (1L << (int)(uint)Shift_amount) - 1L;
			while (num3 >>> (int)(uint)Shift_amount == 0L)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = 0L;
				if ((uint)num < (uint)This->Num_digits)
				{
					num5 = (byte)((sbyte*)(&This->Digits))[(uint)num];
				}
				num3 = num3 * 10L + num5;
				num++;
				Llvm_lifetime_end_p0.Invoke(8L, &num5);
			}
			This->Decimal_point -= num - 1;
			while ((uint)num < (uint)This->Num_digits)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = (byte)((sbyte*)(&This->Digits))[(uint)num];
				Llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = num3 >>> (int)(uint)Shift_amount;
				num3 &= num4;
				((sbyte*)(&This->Digits))[(uint)num2] = (sbyte)num7;
				num3 = num3 * 10L + num6;
				num++;
				num2++;
				Llvm_lifetime_end_p0.Invoke(8L, &num7);
				Llvm_lifetime_end_p0.Invoke(8L, &num6);
			}
			while ((ulong)num3 > 0uL)
			{
				Llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = num3 >>> (int)(uint)Shift_amount;
				num3 &= num4;
				if ((uint)num2 < 800u)
				{
					((sbyte*)(&This->Digits))[(uint)num2] = (sbyte)num8;
					num2++;
				}
				else if ((ulong)num8 > 0uL)
				{
					This->Truncated = 1;
				}
				num3 *= 10L;
				Llvm_lifetime_end_p0.Invoke(8L, &num8);
			}
			This->Num_digits = num2;
			HighPrecisionDecimal_trim_trailing_zeroes.Invoke(This);
			Llvm_lifetime_end_p0.Invoke(8L, &num4);
			Llvm_lifetime_end_p0.Invoke(8L, &num3);
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
