using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19COSHF16_EXCEPTS_NEGE")]
[DemangledName("__llvm_libc_20_1_2_::COSHF16_EXCEPTS_NEG")]
internal static partial class COSHF16_EXCEPTS_NEG
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

	unsafe static COSHF16_EXCEPTS_NEG()
	{
		Value = new fputil_ExceptValues_pfsijn
		{
			values = new InlineArrayBuilder<InlineArray4_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -22104,
					rnd_towardzero_result = 15360,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -16680,
					rnd_towardzero_result = 16822,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -15198,
					rnd_towardzero_result = 21101,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -13956,
					rnd_towardzero_result = 30485,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
