using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L16ASINF_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::ASINF_EXCEPTS_HI")]
internal static partial class ASINF_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_r2mqym __value;

	public unsafe static fputil_ExceptValues_r2mqym* Pointer => unchecked((fputil_ExceptValues_r2mqym*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_r2mqym Value
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

	unsafe static ASINF_EXCEPTS_HI()
	{
		Value = new fputil_ExceptValues_r2mqym
		{
			values = new InlineArrayBuilder<InlineArray2_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1057503770,
					rnd_towardzero_result = 1057990066,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1064780214,
					rnd_towardzero_result = 1067942698,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
