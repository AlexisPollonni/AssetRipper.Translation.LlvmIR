using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L16ASINF_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::ASINF_EXCEPTS_LO")]
internal static partial class ASINF_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_v8stj6 __value;

	public unsafe static Fputil_ExceptValues_v8stj6* Pointer => unchecked((Fputil_ExceptValues_v8stj6*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_v8stj6 Value
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

	unsafe static ASINF_EXCEPTS_LO()
	{
		Value = new Fputil_ExceptValues_v8stj6
		{
			Values = new InlineArrayBuilder<InlineArray2_Fputil_ExceptValues_float_6_Mapping, Fputil_ExceptValues_float_6_Mapping>
			{
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1024049030,
					Rnd_towardzero_result = 1024050732,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1038481950,
					Rnd_towardzero_result = 1038513806,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
