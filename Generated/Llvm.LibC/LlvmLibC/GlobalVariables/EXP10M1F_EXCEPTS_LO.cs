using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19EXP10M1F_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXP10M1F_EXCEPTS_LO")]
internal static partial class EXP10M1F_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_zsuwev __value;

	public unsafe static fputil_ExceptValues_zsuwev* Pointer => unchecked((fputil_ExceptValues_zsuwev*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_zsuwev Value
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

	unsafe static EXP10M1F_EXCEPTS_LO()
	{
		Value = new fputil_ExceptValues_zsuwev
		{
			values = new InlineArrayBuilder<InlineArray11_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 973599399,
					rnd_towardzero_result = 983342071,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 977302389,
					rnd_towardzero_result = 987611449,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1508566562,
					rnd_towardzero_result = -1498699601,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = int.MinValue,
					rnd_towardzero_result = int.MinValue,
					rnd_upward_offset = 0,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1336226044,
					rnd_towardzero_result = -1325667925,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1176528368,
					rnd_towardzero_result = -1165973759,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1171192840,
					rnd_towardzero_result = -1161059483,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1168210381,
					rnd_towardzero_result = -1157631820,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1157632986,
					rnd_towardzero_result = -1147994759,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1152147271,
					rnd_towardzero_result = -1141719567,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1150962522,
					rnd_towardzero_result = -1140608398,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
