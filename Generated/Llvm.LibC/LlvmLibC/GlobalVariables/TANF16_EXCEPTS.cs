using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L14TANF16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::TANF16_EXCEPTS")]
internal static partial class TANF16_EXCEPTS
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

	unsafe static TANF16_EXCEPTS()
	{
		Value = new Fputil_ExceptValues_fkx7qf
		{
			Values = new InlineArrayBuilder<InlineArray9_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 10388,
					Rnd_towardzero_result = 10388,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 12433,
					Rnd_towardzero_result = 12441,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 12440,
					Rnd_towardzero_result = 12448,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 21997,
					Rnd_towardzero_result = 14609,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 24699,
					Rnd_towardzero_result = -14792,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 26446,
					Rnd_towardzero_result = 15229,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 26631,
					Rnd_towardzero_result = 16404,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 28493,
					Rnd_towardzero_result = -16871,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 29488,
					Rnd_towardzero_result = -13470,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
