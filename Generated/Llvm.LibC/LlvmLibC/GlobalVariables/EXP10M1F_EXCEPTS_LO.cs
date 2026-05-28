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
	private static Fputil_ExceptValues_zsuwev __value;

	public unsafe static Fputil_ExceptValues_zsuwev* Pointer => unchecked((Fputil_ExceptValues_zsuwev*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_zsuwev Value
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
		Value = new Fputil_ExceptValues_zsuwev
		{
			Values = new InlineArrayBuilder<InlineArray11_Fputil_ExceptValues_float_6_Mapping, Fputil_ExceptValues_float_6_Mapping>
			{
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 973599399,
					Rnd_towardzero_result = 983342071,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 977302389,
					Rnd_towardzero_result = 987611449,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = -1508566562,
					Rnd_towardzero_result = -1498699601,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = int.MinValue,
					Rnd_towardzero_result = int.MinValue,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = -1336226044,
					Rnd_towardzero_result = -1325667925,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = -1176528368,
					Rnd_towardzero_result = -1165973759,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = -1171192840,
					Rnd_towardzero_result = -1161059483,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = -1168210381,
					Rnd_towardzero_result = -1157631820,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = -1157632986,
					Rnd_towardzero_result = -1147994759,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = -1152147271,
					Rnd_towardzero_result = -1141719567,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = -1150962522,
					Rnd_towardzero_result = -1140608398,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
