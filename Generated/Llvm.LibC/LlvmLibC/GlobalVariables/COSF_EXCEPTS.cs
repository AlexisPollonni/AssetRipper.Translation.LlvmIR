using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L12COSF_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::COSF_EXCEPTS")]
internal static partial class COSF_EXCEPTS
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_x9e5i2 __value;

	public unsafe static fputil_ExceptValues_x9e5i2* Pointer => unchecked((fputil_ExceptValues_x9e5i2*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_x9e5i2 Value
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

	unsafe static COSF_EXCEPTS()
	{
		Value = new fputil_ExceptValues_x9e5i2
		{
			values = new InlineArrayBuilder<InlineArray6_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1429360665,
					rnd_towardzero_result = 1062118866,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1495444096,
					rnd_towardzero_result = 1057533630,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1520718892,
					rnd_towardzero_result = 1056587940,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1595455608,
					rnd_towardzero_result = 1065292987,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1628818193,
					rnd_towardzero_result = 1064834094,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 2079258095,
					rnd_towardzero_result = 1057530396,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
