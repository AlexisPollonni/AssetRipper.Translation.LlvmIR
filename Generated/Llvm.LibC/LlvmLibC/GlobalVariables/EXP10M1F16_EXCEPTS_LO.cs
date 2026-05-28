using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L21EXP10M1F16_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXP10M1F16_EXCEPTS_LO")]
internal static partial class EXP10M1F16_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_x8ns5m __value;

	public unsafe static Fputil_ExceptValues_x8ns5m* Pointer => unchecked((Fputil_ExceptValues_x8ns5m*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_x8ns5m Value
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

	unsafe static EXP10M1F16_EXCEPTS_LO()
	{
		Value = new Fputil_ExceptValues_x8ns5m
		{
			Values = new InlineArrayBuilder<InlineArray3_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 11633,
					Rnd_towardzero_result = 13035,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -30344,
					Rnd_towardzero_result = -29109,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -26744,
					Rnd_towardzero_result = -25517,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
