using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19EXPM1F16_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXPM1F16_EXCEPTS_HI")]
internal static partial class EXPM1F16_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_x8ns5m __value;

	public unsafe static Fputil_ExceptValues_x8ns5m* Pointer => unchecked((Fputil_ExceptValues_x8ns5m*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_x8ns5m Value
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

	unsafe static EXPM1F16_EXCEPTS_HI()
	{
		Value = new Fputil_ExceptValues_x8ns5m
		{
			Values = new InlineArrayBuilder<InlineArray3_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 16141,
					Rnd_towardzero_result = 17619,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -19574,
					Rnd_towardzero_result = -19785,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 12930,
					Rnd_towardzero_result = 13111,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
