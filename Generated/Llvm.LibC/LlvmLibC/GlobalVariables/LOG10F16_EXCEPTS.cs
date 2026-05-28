using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L16LOG10F16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::LOG10F16_EXCEPTS")]
internal static partial class LOG10F16_EXCEPTS
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_dwtyzi __value;

	public unsafe static Fputil_ExceptValues_dwtyzi* Pointer => unchecked((Fputil_ExceptValues_dwtyzi*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_dwtyzi Value
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

	unsafe static LOG10F16_EXCEPTS()
	{
		Value = new Fputil_ExceptValues_dwtyzi
		{
			Values = new InlineArrayBuilder<InlineArray17_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 13199,
					Rnd_towardzero_result = -18173,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 13304,
					Rnd_towardzero_result = -18220,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 14565,
					Rnd_towardzero_result = -19757,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15274,
					Rnd_towardzero_result = -23356,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15276,
					Rnd_towardzero_result = -23385,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15308,
					Rnd_towardzero_result = -24137,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15310,
					Rnd_towardzero_result = -24194,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15350,
					Rnd_towardzero_result = -26534,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15358,
					Rnd_towardzero_result = -28941,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15581,
					Rnd_towardzero_result = 11630,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 16635,
					Rnd_towardzero_result = 13910,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 18688,
					Rnd_towardzero_result = 15360,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 22080,
					Rnd_towardzero_result = 16384,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 22497,
					Rnd_towardzero_result = 16435,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 25552,
					Rnd_towardzero_result = 16896,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 28898,
					Rnd_towardzero_result = 17408,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 29085,
					Rnd_towardzero_result = 17423,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
