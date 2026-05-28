using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19COSHF16_EXCEPTS_NEGE")]
[DemangledName("__llvm_libc_20_1_2_::COSHF16_EXCEPTS_NEG")]
internal static partial class COSHF16_EXCEPTS_NEG
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_pfsijn __value;

	public unsafe static Fputil_ExceptValues_pfsijn* Pointer => unchecked((Fputil_ExceptValues_pfsijn*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_pfsijn Value
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

	unsafe static COSHF16_EXCEPTS_NEG()
	{
		Value = new Fputil_ExceptValues_pfsijn
		{
			Values = new InlineArrayBuilder<InlineArray4_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -22104,
					Rnd_towardzero_result = 15360,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -16680,
					Rnd_towardzero_result = 16822,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -15198,
					Rnd_towardzero_result = 21101,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -13956,
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
