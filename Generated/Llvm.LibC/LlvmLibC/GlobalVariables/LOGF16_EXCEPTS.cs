using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L14LOGF16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::LOGF16_EXCEPTS")]
internal static partial class LOGF16_EXCEPTS
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

	unsafe static LOGF16_EXCEPTS()
	{
		Value = new fputil_ExceptValues_ist8fx
		{
			values = new InlineArrayBuilder<InlineArray5_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 6453,
					rnd_towardzero_result = -14855,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 7544,
					rnd_towardzero_result = -15045,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 15356,
					rnd_towardzero_result = -26623,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 15358,
					rnd_towardzero_result = -27648,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 16689,
					rnd_towardzero_result = 15265,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
