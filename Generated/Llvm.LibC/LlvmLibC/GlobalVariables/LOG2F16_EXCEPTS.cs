using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L15LOG2F16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::LOG2F16_EXCEPTS")]
internal static partial class LOG2F16_EXCEPTS
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

	unsafe static LOG2F16_EXCEPTS()
	{
		Value = new fputil_ExceptValues_rhfsch
		{
			values = new InlineArrayBuilder<InlineArray2_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 15267,
					rnd_towardzero_result = -21430,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 15341,
					rnd_towardzero_result = -23838,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
