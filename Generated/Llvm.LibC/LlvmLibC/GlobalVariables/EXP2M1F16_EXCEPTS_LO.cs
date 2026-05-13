using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L20EXP2M1F16_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2M1F16_EXCEPTS_LO")]
internal static partial class EXP2M1F16_EXCEPTS_LO
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

	unsafe static EXP2M1F16_EXCEPTS_LO()
	{
		Value = new fputil_ExceptValues_susv2z
		{
			values = new InlineArrayBuilder<InlineArray6_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 2877,
					rnd_towardzero_result = 2308,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 3391,
					rnd_towardzero_result = 2885,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 4492,
					rnd_towardzero_result = 4017,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 8636,
					rnd_towardzero_result = 8186,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -26856,
					rnd_towardzero_result = -27414,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -26817,
					rnd_towardzero_result = -27387,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
