using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19EXP10M1F_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXP10M1F_EXCEPTS_HI")]
internal static partial class Llvm_libc_20_1_2_EXP10M1F_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_92qrhp __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_92qrhp* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_92qrhp*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_92qrhp Value
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

	unsafe static Llvm_libc_20_1_2_EXP10M1F_EXCEPTS_HI()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_92qrhp
		{
			Values = new InlineArrayBuilder<InlineArray19_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1002871031,
					Rnd_towardzero_result = 1013333798,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1003007975,
					Rnd_towardzero_result = 1013493689,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1004436673,
					Rnd_towardzero_result = 1015092372,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1011679109,
					Rnd_towardzero_result = 1022325259,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1018885386,
					Rnd_towardzero_result = 1029504907,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1023151538,
					Rnd_towardzero_result = 1033263966,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1098743648,
					Rnd_towardzero_result = 1506165765,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1147275190,
					Rnd_towardzero_result = -1137386203,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1146966946,
					Rnd_towardzero_result = -1137035300,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1146758632,
					Rnd_towardzero_result = -1136798222,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1145325980,
					Rnd_towardzero_result = -1135169182,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1141370272,
					Rnd_towardzero_result = -1131573141,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1141208969,
					Rnd_towardzero_result = -1131481899,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1140481566,
					Rnd_towardzero_result = -1130862068,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1139658894,
					Rnd_towardzero_result = -1129933373,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1132660371,
					Rnd_towardzero_result = -1123086141,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1132170736,
					Rnd_towardzero_result = -1122652640,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1123652062,
					Rnd_towardzero_result = -1114304343,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1117445743,
					Rnd_towardzero_result = -1107852392,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
