using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L20EXP2M1F16_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2M1F16_EXCEPTS_HI")]
internal static partial class EXP2M1F16_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_susv2z __value;

	public unsafe static fputil_ExceptValues_susv2z* Pointer => unchecked((fputil_ExceptValues_susv2z*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_susv2z Value
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

	unsafe static EXP2M1F16_EXCEPTS_HI()
	{
		Value = new fputil_ExceptValues_susv2z
		{
			values = new InlineArrayBuilder<InlineArray6_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 13206,
					rnd_towardzero_result = 12727,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 14006,
					rnd_towardzero_result = 13670,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 14263,
					rnd_towardzero_result = 13913,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -19967,
					rnd_towardzero_result = -20531,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -19508,
					rnd_towardzero_result = -20231,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -18267,
					rnd_towardzero_result = -19124,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
