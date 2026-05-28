using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19SINHF16_EXCEPTS_NEGE")]
[DemangledName("__llvm_libc_20_1_2_::SINHF16_EXCEPTS_NEG")]
internal static partial class SINHF16_EXCEPTS_NEG
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_iy3bzz __value;

	public unsafe static Fputil_ExceptValues_iy3bzz* Pointer => unchecked((Fputil_ExceptValues_iy3bzz*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_iy3bzz Value
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

	unsafe static SINHF16_EXCEPTS_NEG()
	{
		Value = new Fputil_ExceptValues_iy3bzz
		{
			Values = new InlineArrayBuilder<InlineArray12_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -22075,
					Rnd_towardzero_result = -22075,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -21356,
					Rnd_towardzero_result = -21356,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -20524,
					Rnd_towardzero_result = -20519,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -19014,
					Rnd_towardzero_result = -18983,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -17770,
					Rnd_towardzero_result = -17574,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -15561,
					Rnd_towardzero_result = -13157,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -15549,
					Rnd_towardzero_result = -13130,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -15354,
					Rnd_towardzero_result = -12548,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -15169,
					Rnd_towardzero_result = -11471,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -15045,
					Rnd_towardzero_result = -10793,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -14807,
					Rnd_towardzero_result = -9371,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -13956,
					Rnd_towardzero_result = -2283,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				}
			}
		};
		_ = Pointer;
	}
}
