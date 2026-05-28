using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L15EXP2F16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2F16_EXCEPTS")]
internal static partial class EXP2F16_EXCEPTS
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

	unsafe static EXP2F16_EXCEPTS()
	{
		Value = new Fputil_ExceptValues_x8ns5m
		{
			Values = new InlineArrayBuilder<InlineArray3_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 4549,
					Rnd_towardzero_result = 15360,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -21162,
					Rnd_towardzero_result = 15245,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -20649,
					Rnd_towardzero_result = 15203,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
