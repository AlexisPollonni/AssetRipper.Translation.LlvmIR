using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L16ASINF_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::ASINF_EXCEPTS_LO")]
internal static partial class ASINF_EXCEPTS_LO
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

	unsafe static ASINF_EXCEPTS_LO()
	{
		Value = new fputil_ExceptValues_r2mqym
		{
			values = new InlineArrayBuilder<InlineArray2_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1024049030,
					rnd_towardzero_result = 1024050732,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1038481950,
					rnd_towardzero_result = 1038513806,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
