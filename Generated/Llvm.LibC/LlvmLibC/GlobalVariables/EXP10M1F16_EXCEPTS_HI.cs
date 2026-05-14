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
	private static fputil_ExceptValues_eezwkt __value;

	public unsafe static fputil_ExceptValues_eezwkt* Pointer => unchecked((fputil_ExceptValues_eezwkt*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_eezwkt Value
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
		Value = new fputil_ExceptValues_eezwkt
		{
			values = new InlineArrayBuilder<InlineArray6_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 13885,
					rnd_towardzero_result = 15825,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 13911,
					rnd_towardzero_result = 15862,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 14145,
					rnd_towardzero_result = 16220,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 16432,
					rnd_towardzero_result = 22449,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 16494,
					rnd_towardzero_result = 22807,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 17597,
					rnd_towardzero_result = 31406,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
