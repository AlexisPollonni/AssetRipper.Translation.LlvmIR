using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L20EXP2M1F16_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2M1F16_EXCEPTS_LO")]
internal static partial class EXP2M1F16_EXCEPTS_LO
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

	unsafe static EXP2M1F16_EXCEPTS_LO()
	{
		Value = new Fputil_ExceptValues_eezwkt
		{
			Values = new InlineArrayBuilder<InlineArray6_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 2877,
					Rnd_towardzero_result = 2308,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 3391,
					Rnd_towardzero_result = 2885,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 4492,
					Rnd_towardzero_result = 4017,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 8636,
					Rnd_towardzero_result = 8186,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -26856,
					Rnd_towardzero_result = -27414,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -26817,
					Rnd_towardzero_result = -27387,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
