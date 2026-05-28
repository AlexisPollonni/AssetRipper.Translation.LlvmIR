using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L21EXP10M1F16_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXP10M1F16_EXCEPTS_HI")]
internal static partial class EXP10M1F16_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_eezwkt __value;

	public unsafe static Fputil_ExceptValues_eezwkt* Pointer => unchecked((Fputil_ExceptValues_eezwkt*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_eezwkt Value
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

	unsafe static EXP10M1F16_EXCEPTS_HI()
	{
		Value = new Fputil_ExceptValues_eezwkt
		{
			Values = new InlineArrayBuilder<InlineArray6_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 13885,
					Rnd_towardzero_result = 15825,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 13911,
					Rnd_towardzero_result = 15862,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 14145,
					Rnd_towardzero_result = 16220,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 16432,
					Rnd_towardzero_result = 22449,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 16494,
					Rnd_towardzero_result = 22807,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 17597,
					Rnd_towardzero_result = 31406,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				}
			}
		};
		_ = Pointer;
	}
}
