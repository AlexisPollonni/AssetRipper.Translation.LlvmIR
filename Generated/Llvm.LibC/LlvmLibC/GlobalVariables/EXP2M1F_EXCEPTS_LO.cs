using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L18EXP2M1F_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2M1F_EXCEPTS_LO")]
internal static partial class EXP2M1F_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_rejery __value;

	public unsafe static fputil_ExceptValues_rejery* Pointer => unchecked((fputil_ExceptValues_rejery*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_rejery Value
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

	unsafe static EXP2M1F_EXCEPTS_LO()
	{
		Value = new fputil_ExceptValues_rejery
		{
			values = new InlineArrayBuilder<InlineArray8_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 765161031,
					rnd_towardzero_result = 760707337,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 907093147,
					rnd_towardzero_result = 902379015,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 904443536,
					rnd_towardzero_result = 899763702,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 948685391,
					rnd_towardzero_result = 943836032,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1395777777,
					rnd_towardzero_result = -1399922858,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1348025126,
					rnd_towardzero_result = -1352191781,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1160546974,
					rnd_towardzero_result = -1164804755,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1124882121,
					rnd_towardzero_result = -1129895441,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
