using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal20HighPrecisionDecimal22LEFT_SHIFT_DIGIT_TABLEE")]
[DemangledName("__llvm_libc_20_1_2_::internal::HighPrecisionDecimal::LEFT_SHIFT_DIGIT_TABLE")]
internal static partial class internal_HighPrecisionDecimal_LEFT_SHIFT_DIGIT_TABLE
{
	[FixedAddressValueType]
	private static InlineArray61_internal_LShiftTableEntry __value;

	public unsafe static InlineArray61_internal_LShiftTableEntry* Pointer => unchecked((InlineArray61_internal_LShiftTableEntry*)Unsafe.AsPointer(ref __value));

	public static InlineArray61_internal_LShiftTableEntry Value
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

	unsafe static internal_HighPrecisionDecimal_LEFT_SHIFT_DIGIT_TABLE()
	{
		Value = new InlineArrayBuilder<InlineArray61_internal_LShiftTableEntry, internal_LShiftTableEntry>
		{
			new internal_LShiftTableEntry
			{
				new_digits = 0,
				power_of_five = str_2_126.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 1,
				power_of_five = str_3_127.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 1,
				power_of_five = str_4_128.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 1,
				power_of_five = str_5.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 2,
				power_of_five = str_6.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 2,
				power_of_five = str_7.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 2,
				power_of_five = str_8.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 3,
				power_of_five = str_9.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 3,
				power_of_five = str_10.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 3,
				power_of_five = str_11.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 4,
				power_of_five = str_12.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 4,
				power_of_five = str_13.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 4,
				power_of_five = str_14.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 4,
				power_of_five = str_15.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 5,
				power_of_five = str_16.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 5,
				power_of_five = str_17.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 5,
				power_of_five = str_18.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 6,
				power_of_five = str_19.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 6,
				power_of_five = str_20.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 6,
				power_of_five = str_21.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 7,
				power_of_five = str_22.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 7,
				power_of_five = str_23.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 7,
				power_of_five = str_24.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 7,
				power_of_five = str_25.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 8,
				power_of_five = str_26.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 8,
				power_of_five = str_27.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 8,
				power_of_five = str_28.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 9,
				power_of_five = str_29.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 9,
				power_of_five = str_30.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 9,
				power_of_five = str_31.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 10,
				power_of_five = str_32.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 10,
				power_of_five = str_33.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 10,
				power_of_five = str_34.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 10,
				power_of_five = str_35.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 11,
				power_of_five = str_36.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 11,
				power_of_five = str_37.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 11,
				power_of_five = str_38.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 12,
				power_of_five = str_39.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 12,
				power_of_five = str_40.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 12,
				power_of_five = str_41.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 13,
				power_of_five = str_42.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 13,
				power_of_five = str_43.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 13,
				power_of_five = str_44.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 13,
				power_of_five = str_45.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 14,
				power_of_five = str_46.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 14,
				power_of_five = str_47.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 14,
				power_of_five = str_48.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 15,
				power_of_five = str_49.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 15,
				power_of_five = str_50.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 15,
				power_of_five = str_51.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 16,
				power_of_five = str_52.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 16,
				power_of_five = str_53.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 16,
				power_of_five = str_54.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 16,
				power_of_five = str_55.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 17,
				power_of_five = str_56.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 17,
				power_of_five = str_57.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 17,
				power_of_five = str_58.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 18,
				power_of_five = str_59_129.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 18,
				power_of_five = str_60.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 18,
				power_of_five = str_61.Pointer
			},
			new internal_LShiftTableEntry
			{
				new_digits = 19,
				power_of_five = str_62.Pointer
			}
		};
		PointerIndices.Register(Pointer);
	}
}
