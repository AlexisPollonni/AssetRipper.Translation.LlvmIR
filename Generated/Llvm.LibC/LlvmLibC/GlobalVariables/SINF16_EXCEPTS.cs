using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L14SINF16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::SINF16_EXCEPTS")]
internal static partial class SINF16_EXCEPTS
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_pfsijn __value;

	public unsafe static fputil_ExceptValues_pfsijn* Pointer => unchecked((fputil_ExceptValues_pfsijn*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_pfsijn Value
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

	unsafe static SINF16_EXCEPTS()
	{
		Value = new fputil_ExceptValues_pfsijn
		{
			values = new InlineArrayBuilder<InlineArray4_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 11077,
					rnd_towardzero_result = 11075,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 22620,
					rnd_towardzero_result = 15267,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 23728,
					rnd_towardzero_result = -17409,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 20981,
					rnd_towardzero_result = -18417,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
