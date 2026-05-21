using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L16ASINF_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::ASINF_EXCEPTS_HI")]
internal static partial class Llvm_libc_20_1_2_ASINF_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6 __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6 Value
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

	unsafe static Llvm_libc_20_1_2_ASINF_EXCEPTS_HI()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_v8stj6
		{
			Values = new InlineArrayBuilder<InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1057503770,
					Rnd_towardzero_result = 1057990066,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1064780214,
					Rnd_towardzero_result = 1067942698,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
