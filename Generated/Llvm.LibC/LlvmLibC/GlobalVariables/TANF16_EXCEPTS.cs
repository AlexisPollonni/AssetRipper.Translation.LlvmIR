using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L14TANF16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::TANF16_EXCEPTS")]
internal static partial class TANF16_EXCEPTS
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_fkx7qf __value;

	public unsafe static fputil_ExceptValues_fkx7qf* Pointer => unchecked((fputil_ExceptValues_fkx7qf*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_fkx7qf Value
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

	unsafe static TANF16_EXCEPTS()
	{
		Value = new fputil_ExceptValues_fkx7qf
		{
			values = new InlineArrayBuilder<InlineArray9_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 10388,
					rnd_towardzero_result = 10388,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 12433,
					rnd_towardzero_result = 12441,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 12440,
					rnd_towardzero_result = 12448,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 21997,
					rnd_towardzero_result = 14609,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 24699,
					rnd_towardzero_result = -14792,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 26446,
					rnd_towardzero_result = 15229,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 26631,
					rnd_towardzero_result = 16404,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 28493,
					rnd_towardzero_result = -16871,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 29488,
					rnd_towardzero_result = -13470,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
