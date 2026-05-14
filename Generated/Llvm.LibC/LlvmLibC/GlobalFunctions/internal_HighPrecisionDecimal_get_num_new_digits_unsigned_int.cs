using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal18get_num_new_digitsEj")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::get_num_new_digits(unsigned int)")]
internal static partial class internal_HighPrecisionDecimal_get_num_new_digits_unsigned_int
{
	public unsafe static int Invoke(internal_HighPrecisionDecimal* @this, int lshift_amount)
	{
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		llvm_lifetime_start_p0.Invoke(8L, &ptr);
		unchecked
		{
			ptr = ((internal_LShiftTableEntry*)internal_HighPrecisionDecimal_LEFT_SHIFT_DIGIT_TABLE.Pointer)[(uint)lshift_amount].power_of_five;
			llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((internal_LShiftTableEntry*)internal_HighPrecisionDecimal_LEFT_SHIFT_DIGIT_TABLE.Pointer)[(uint)lshift_amount].new_digits;
			llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = 0;
			int result;
			while (true)
			{
				if (((sbyte*)ptr)[(uint)num2] != 0)
				{
					if ((uint)num2 >= (uint)@this->num_digits)
					{
						result = num - 1;
						break;
					}
					if ((byte)((sbyte*)(&@this->digits))[(uint)num2] != internal_b36_char_to_int_int_122.Invoke(((sbyte*)ptr)[(uint)num2]))
					{
						result = num - InstructionHelper.Select((byte)((sbyte*)(&@this->digits))[(uint)num2] < internal_b36_char_to_int_int_122.Invoke(((sbyte*)ptr)[(uint)num2]), 1, 0);
						break;
					}
					num2++;
					continue;
				}
				result = num;
				break;
			}
			llvm_lifetime_end_p0.Invoke(4L, &num2);
			llvm_lifetime_end_p0.Invoke(4L, &num);
			llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
