using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L12TANF_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::TANF_EXCEPTS")]
internal static partial class TANF_EXCEPTS
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

	unsafe static TANF_EXCEPTS()
	{
		Value = new fputil_ExceptValues_x9e5i2
		{
			values = new InlineArrayBuilder<InlineArray6_fputil_ExceptValues_float_6_Mapping, fputil_ExceptValues_float_6_Mapping>
			{
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1297535829,
					rnd_towardzero_result = 1047789954,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1346572338,
					rnd_towardzero_result = -1102645461,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1473753325,
					rnd_towardzero_result = 1051748579,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1501578334,
					rnd_towardzero_result = 1071976296,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1677494014,
					rnd_towardzero_result = 1059897294,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_float_6_Mapping
				{
					input = 1792239369,
					rnd_towardzero_result = -1084051305,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
