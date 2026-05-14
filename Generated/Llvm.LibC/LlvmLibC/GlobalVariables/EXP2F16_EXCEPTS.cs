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
	private static fputil_ExceptValues_x8ns5m __value;

	public unsafe static fputil_ExceptValues_x8ns5m* Pointer => unchecked((fputil_ExceptValues_x8ns5m*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_x8ns5m Value
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
		Value = new fputil_ExceptValues_x8ns5m
		{
			values = new InlineArrayBuilder<InlineArray3_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 4549,
					rnd_towardzero_result = 15360,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -21162,
					rnd_towardzero_result = 15245,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -20649,
					rnd_towardzero_result = 15203,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
