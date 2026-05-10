using LlvmLibC.Helpers;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal10left_shiftEj")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::left_shift(unsigned int)")]
internal static partial class internal_HighPrecisionDecimal_left_shift_unsigned_int
{
	public unsafe static void Invoke(void* @this, int shift_amount)
	{
		int num = 0;
		int num2 = 0;
		int num3 = 0;
		long num4 = 0L;
		long num5 = 0L;
		long num6 = 0L;
		long num7 = 0L;
		long num8 = 0L;
		llvm_lifetime_start_p0.Invoke(4L, &num);
		num = internal_HighPrecisionDecimal_get_num_new_digits_unsigned_int.Invoke(@this, shift_amount);
		llvm_lifetime_start_p0.Invoke(4L, &num2);
		unchecked
		{
			num2 = ((internal_HighPrecisionDecimal*)@this)->num_digits - 1;
			llvm_lifetime_start_p0.Invoke(4L, &num3);
			num3 = ((internal_HighPrecisionDecimal*)@this)->num_digits + num;
			llvm_lifetime_start_p0.Invoke(8L, &num4);
			num4 = 0L;
			while (num2 >= 0)
			{
				long num9 = (long)((ulong)(byte)((sbyte*)(&((internal_HighPrecisionDecimal*)@this)->digits))[num2] << (int)(uint)shift_amount);
				num4 += num9;
				llvm_lifetime_start_p0.Invoke(8L, &num5);
				num5 = (long)((ulong)num4 / 10uL);
				llvm_lifetime_start_p0.Invoke(8L, &num6);
				num6 = num4 - 10L * num5;
				num3 += -1;
				if ((uint)num3 < 800u)
				{
					((sbyte*)(&((internal_HighPrecisionDecimal*)@this)->digits))[(uint)num3] = (sbyte)num6;
				}
				else if (num6 != 0L)
				{
					((internal_HighPrecisionDecimal*)@this)->truncated = 1;
				}
				num4 = num5;
				num2 = checked(num2 + -1);
				llvm_lifetime_end_p0.Invoke(8L, &num6);
				llvm_lifetime_end_p0.Invoke(8L, &num5);
			}
			while ((ulong)num4 > 0uL)
			{
				llvm_lifetime_start_p0.Invoke(8L, &num7);
				num7 = (long)((ulong)num4 / 10uL);
				llvm_lifetime_start_p0.Invoke(8L, &num8);
				num8 = num4 - 10L * num7;
				num3 += -1;
				if ((uint)num3 < 800u)
				{
					((sbyte*)(&((internal_HighPrecisionDecimal*)@this)->digits))[(uint)num3] = (sbyte)num8;
				}
				else if (num8 != 0L)
				{
					((internal_HighPrecisionDecimal*)@this)->truncated = 1;
				}
				num4 = num7;
				llvm_lifetime_end_p0.Invoke(8L, &num8);
				llvm_lifetime_end_p0.Invoke(8L, &num7);
			}
			((internal_HighPrecisionDecimal*)@this)->num_digits += num;
			if ((uint)((internal_HighPrecisionDecimal*)@this)->num_digits > 800u)
			{
				((internal_HighPrecisionDecimal*)@this)->num_digits = 800;
			}
			((internal_HighPrecisionDecimal*)@this)->decimal_point += num;
			internal_HighPrecisionDecimal_trim_trailing_zeroes.Invoke(@this);
			llvm_lifetime_end_p0.Invoke(8L, &num4);
			llvm_lifetime_end_p0.Invoke(4L, &num3);
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
		}
	}
}
