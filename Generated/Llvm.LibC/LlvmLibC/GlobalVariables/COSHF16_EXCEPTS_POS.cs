using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19COSHF16_EXCEPTS_POSE")]
[DemangledName("__llvm_libc_20_1_2_::COSHF16_EXCEPTS_POS")]
internal static partial class COSHF16_EXCEPTS_POS
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_fkx7qf __value;

	public unsafe static Fputil_ExceptValues_fkx7qf* Pointer => unchecked((Fputil_ExceptValues_fkx7qf*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_fkx7qf Value
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

	unsafe static COSHF16_EXCEPTS_POS()
	{
		Value = new Fputil_ExceptValues_fkx7qf
		{
			Values = new InlineArrayBuilder<InlineArray9_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 10664,
					Rnd_towardzero_result = 15360,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15921,
					Rnd_towardzero_result = 16618,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15973,
					Rnd_towardzero_result = 16678,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 16088,
					Rnd_towardzero_result = 16822,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 17064,
					Rnd_towardzero_result = 19194,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 17201,
					Rnd_towardzero_result = 19599,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 17570,
					Rnd_towardzero_result = 21101,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 18006,
					Rnd_towardzero_result = 23657,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 18812,
					Rnd_towardzero_result = 30485,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				}
			}
		};
		_ = Pointer;
	}
}
