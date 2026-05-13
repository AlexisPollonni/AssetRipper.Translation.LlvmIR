using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19EXPM1F16_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXPM1F16_EXCEPTS_HI")]
internal static partial class EXPM1F16_EXCEPTS_HI
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

	unsafe static EXPM1F16_EXCEPTS_HI()
	{
		Value = new fputil_ExceptValues_rhfsch
		{
			values = new InlineArrayBuilder<InlineArray2_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 16141,
					rnd_towardzero_result = 17619,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = -19574,
					rnd_towardzero_result = -19785,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
