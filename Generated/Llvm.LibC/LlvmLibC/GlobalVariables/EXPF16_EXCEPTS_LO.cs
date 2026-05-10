using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L17EXPF16_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXPF16_EXCEPTS_LO")]
internal static partial class EXPF16_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_rhfsch __value;

	public unsafe static fputil_ExceptValues_rhfsch* Pointer => unchecked((fputil_ExceptValues_rhfsch*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_rhfsch Value
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

	unsafe static EXPF16_EXCEPTS_LO()
	{
		Value = new fputil_ExceptValues_rhfsch
		{
			values = new InlineArrayBuilder<InlineArray2_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 8057,
					rnd_towardzero_result = 15367,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 9679,
					rnd_towardzero_result = 15383,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
