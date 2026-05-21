using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_right_shift
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal11right_shiftEj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::right_shift(unsigned int)")]
	public unsafe static void Invoke(internal_HighPrecisionDecimal* @this, [NativeType("unsigned int")] int shift_amount)
	{
		int num = 0;
		int num2 = 0;
		long num3 = 0L;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = 0;
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		num2 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &num3);
		num3 = 0L;
		llvm_lifetime_start_p0.Invoke(8L, &num4);
		unchecked
		{
			num4 = (1L << (int)(uint)shift_amount) - 1L;
			while (num3 >>> (int)(uint)shift_amount == 0L)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = 0L;
				if ((uint)num < (uint)@this->num_digits)
				{
					num5 = (byte)((sbyte*)(&@this->digits))[(uint)num];
				}
				num3 = num3 * 10L + num5;
				num++;
				llvm_lifetime_end_p0.Invoke(8L, &num5);
			}
			@this->decimal_point -= num - 1;
			while ((uint)num < (uint)@this->num_digits)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = (byte)((sbyte*)(&@this->digits))[(uint)num];
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = num3 >>> (int)(uint)shift_amount;
				num3 &= num4;
				((sbyte*)(&@this->digits))[(uint)num2] = (sbyte)num7;
				num3 = num3 * 10L + num6;
				num++;
				num2++;
				llvm_lifetime_end_p0.Invoke(8L, &num7);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
			}
			while ((ulong)num3 > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = num3 >>> (int)(uint)shift_amount;
				num3 &= num4;
				if ((uint)num2 < 800u)
				{
					((sbyte*)(&@this->digits))[(uint)num2] = (sbyte)num8;
					num2++;
				}
				else if ((ulong)num8 > 0uL)
				{
					@this->truncated = 1;
				}
				num3 *= 10L;
				llvm_lifetime_end_p0.Invoke(8L, &num8);
			}
			@this->num_digits = num2;
			HighPrecisionDecimal_trim_trailing_zeroes.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(8L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
