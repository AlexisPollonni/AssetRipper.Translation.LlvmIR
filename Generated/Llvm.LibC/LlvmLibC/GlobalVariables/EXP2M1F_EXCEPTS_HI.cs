using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L18EXP2M1F_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2M1F_EXCEPTS_HI")]
internal static partial class EXP2M1F_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_wd8iaa __value;

	public unsafe static fputil_ExceptValues_wd8iaa* Pointer => unchecked((fputil_ExceptValues_wd8iaa*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_wd8iaa Value
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

	unsafe static EXP2M1F_EXCEPTS_HI()
	{
		Value = new fputil_ExceptValues_wd8iaa
		{
			values = new InlineArrayBuilder<InlineArray3_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1057707193,
					rnd_towardzero_result = 1055564505,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1118860970,
					rnd_towardzero_result = -1123198138,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = -1116783154,
					rnd_towardzero_result = -1121811334,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
