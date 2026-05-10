using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L16EXP10F16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::EXP10F16_EXCEPTS")]
internal static partial class EXP10F16_EXCEPTS
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_ist8fx __value;

	public unsafe static fputil_ExceptValues_ist8fx* Pointer => unchecked((fputil_ExceptValues_ist8fx*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_ist8fx Value
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

	unsafe static EXP10F16_EXCEPTS()
	{
		Value = new fputil_ExceptValues_ist8fx
		{
			values = new InlineArrayBuilder<InlineArray5_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 13885,
					rnd_towardzero_result = 16616,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 13911,
					rnd_towardzero_result = 16635,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -21498,
					rnd_towardzero_result = 15084,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -16630,
					rnd_towardzero_result = 9331,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -15481,
					rnd_towardzero_result = 2469,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
