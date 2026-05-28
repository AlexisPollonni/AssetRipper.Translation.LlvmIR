using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.GlobalVariables;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class HighPrecisionDecimal_get_num_new_digits
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal18get_num_new_digitsEj")]
	[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::get_num_new_digits(unsigned int)")]
	public unsafe static int Invoke([MangledName("this")] Internal_HighPrecisionDecimal* This, [MangledName("lshift_amount")][NativeType("unsigned int")] int Lshift_amount)
	{
		void* ptr = null;
		int num = 0;
		int num2 = 0;
		Llvm_lifetime_start_p0.Invoke(8L, &ptr);
		unchecked
		{
			ptr = ((Internal_LShiftTableEntry*)Internal_HighPrecisionDecimal_LEFT_SHIFT_DIGIT_TABLE.Pointer)[(uint)Lshift_amount].Power_of_five;
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = ((Internal_LShiftTableEntry*)Internal_HighPrecisionDecimal_LEFT_SHIFT_DIGIT_TABLE.Pointer)[(uint)Lshift_amount].New_digits;
			Llvm_lifetime_start_p0.Invoke(4L, &num2);
			num2 = 0;
			int result;
			while (true)
			{
				if (((sbyte*)ptr)[(uint)num2] != 0)
				{
					if ((uint)num2 >= (uint)This->Num_digits)
					{
						result = num - 1;
						break;
					}
					if ((byte)((sbyte*)(&This->Digits))[(uint)num2] != Internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)ptr)[(uint)num2]))
					{
						result = num - InstructionHelper.Select((byte)((sbyte*)(&This->Digits))[(uint)num2] < Internal_b36_char_to_int_kxqrdt.Invoke(((sbyte*)ptr)[(uint)num2]), 1, 0);
						break;
					}
					num2++;
					continue;
				}
				result = num;
				break;
			}
			Llvm_lifetime_end_p0.Invoke(4L, &num2);
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(8L, &ptr);
			return result;
		}
	}
}
