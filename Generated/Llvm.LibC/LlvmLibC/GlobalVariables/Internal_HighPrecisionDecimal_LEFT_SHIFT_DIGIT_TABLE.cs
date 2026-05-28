using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal22LEFT_SHIFT_DIGIT_TABLEE")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::LEFT_SHIFT_DIGIT_TABLE")]
internal static partial class Internal_HighPrecisionDecimal_LEFT_SHIFT_DIGIT_TABLE
{
	[FixedAddressValueType]
	private static InlineArray61_Internal_LShiftTableEntry __value;

	public unsafe static InlineArray61_Internal_LShiftTableEntry* Pointer => unchecked((InlineArray61_Internal_LShiftTableEntry*)Unsafe.AsPointer(ref __value));

	public static InlineArray61_Internal_LShiftTableEntry Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static Internal_HighPrecisionDecimal_LEFT_SHIFT_DIGIT_TABLE()
	{
		Value = new InlineArrayBuilder<InlineArray61_Internal_LShiftTableEntry, Internal_LShiftTableEntry>
		{
			new Internal_LShiftTableEntry
			{
				New_digits = 0,
				Power_of_five = Str_2_126.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 1,
				Power_of_five = Str_3_127.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 1,
				Power_of_five = Str_4_128.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 1,
				Power_of_five = Str_5.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 2,
				Power_of_five = Str_6.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 2,
				Power_of_five = Str_7.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 2,
				Power_of_five = Str_8.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 3,
				Power_of_five = Str_9.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 3,
				Power_of_five = Str_10.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 3,
				Power_of_five = Str_11.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 4,
				Power_of_five = Str_12.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 4,
				Power_of_five = Str_13.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 4,
				Power_of_five = Str_14.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 4,
				Power_of_five = Str_15.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 5,
				Power_of_five = Str_16.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 5,
				Power_of_five = Str_17.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 5,
				Power_of_five = Str_18.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 6,
				Power_of_five = Str_19.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 6,
				Power_of_five = Str_20.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 6,
				Power_of_five = Str_21.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 7,
				Power_of_five = Str_22.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 7,
				Power_of_five = Str_23.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 7,
				Power_of_five = Str_24.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 7,
				Power_of_five = Str_25.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 8,
				Power_of_five = Str_26.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 8,
				Power_of_five = Str_27.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 8,
				Power_of_five = Str_28.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 9,
				Power_of_five = Str_29.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 9,
				Power_of_five = Str_30.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 9,
				Power_of_five = Str_31.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 10,
				Power_of_five = Str_32.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 10,
				Power_of_five = Str_33.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 10,
				Power_of_five = Str_34.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 10,
				Power_of_five = Str_35.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 11,
				Power_of_five = Str_36.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 11,
				Power_of_five = Str_37.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 11,
				Power_of_five = Str_38.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 12,
				Power_of_five = Str_39.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 12,
				Power_of_five = Str_40.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 12,
				Power_of_five = Str_41.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 13,
				Power_of_five = Str_42.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 13,
				Power_of_five = Str_43.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 13,
				Power_of_five = Str_44.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 13,
				Power_of_five = Str_45.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 14,
				Power_of_five = Str_46.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 14,
				Power_of_five = Str_47.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 14,
				Power_of_five = Str_48.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 15,
				Power_of_five = Str_49.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 15,
				Power_of_five = Str_50.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 15,
				Power_of_five = Str_51.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 16,
				Power_of_five = Str_52.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 16,
				Power_of_five = Str_53.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 16,
				Power_of_five = Str_54.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 16,
				Power_of_five = Str_55.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 17,
				Power_of_five = Str_56.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 17,
				Power_of_five = Str_57.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 17,
				Power_of_five = Str_58.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 18,
				Power_of_five = Str_59_129.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 18,
				Power_of_five = Str_60.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 18,
				Power_of_five = Str_61.Pointer
			},
			new Internal_LShiftTableEntry
			{
				New_digits = 19,
				Power_of_five = Str_62.Pointer
			}
		};
		_ = Pointer;
	}
}
