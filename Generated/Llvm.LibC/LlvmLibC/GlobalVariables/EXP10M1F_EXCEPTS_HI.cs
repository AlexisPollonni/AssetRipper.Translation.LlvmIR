using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19EXP10M1F_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXP10M1F_EXCEPTS_HI")]
internal static partial class EXP10M1F_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_92qrhp __value;

	public unsafe static fputil_ExceptValues_92qrhp* Pointer => unchecked((fputil_ExceptValues_92qrhp*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_92qrhp Value
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

	unsafe static EXP10M1F_EXCEPTS_HI()
	{
		Value = new fputil_ExceptValues_92qrhp
		{
			values = new InlineArrayBuilder<InlineArray19_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1002871031,
					rnd_towardzero_result = 1013333798,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1003007975,
					rnd_towardzero_result = 1013493689,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1004436673,
					rnd_towardzero_result = 1015092372,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1011679109,
					rnd_towardzero_result = 1022325259,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1018885386,
					rnd_towardzero_result = 1029504907,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1023151538,
					rnd_towardzero_result = 1033263966,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1098743648,
					rnd_towardzero_result = 1506165765,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1147275190,
					rnd_towardzero_result = -1137386203,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1146966946,
					rnd_towardzero_result = -1137035300,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1146758632,
					rnd_towardzero_result = -1136798222,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1145325980,
					rnd_towardzero_result = -1135169182,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1141370272,
					rnd_towardzero_result = -1131573141,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1141208969,
					rnd_towardzero_result = -1131481899,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1140481566,
					rnd_towardzero_result = -1130862068,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1139658894,
					rnd_towardzero_result = -1129933373,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1132660371,
					rnd_towardzero_result = -1123086141,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1132170736,
					rnd_towardzero_result = -1122652640,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1123652062,
					rnd_towardzero_result = -1114304343,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1117445743,
					rnd_towardzero_result = -1107852392,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
