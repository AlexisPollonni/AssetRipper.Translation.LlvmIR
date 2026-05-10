using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L21EXP10M1F16_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXP10M1F16_EXCEPTS_LO")]
internal static partial class EXP10M1F16_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_uk6z3c __value;

	public unsafe static fputil_ExceptValues_uk6z3c* Pointer => unchecked((fputil_ExceptValues_uk6z3c*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_uk6z3c Value
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

	unsafe static EXP10M1F16_EXCEPTS_LO()
	{
		Value = new fputil_ExceptValues_uk6z3c
		{
			values = new InlineArrayBuilder<InlineArray3_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 11633,
					rnd_towardzero_result = 13035,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -30344,
					rnd_towardzero_result = -29109,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -26744,
					rnd_towardzero_result = -25517,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
