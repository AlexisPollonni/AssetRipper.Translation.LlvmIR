using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L13ACOSF_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::ACOSF_EXCEPTS")]
internal static partial class Llvm_libc_20_1_2_ACOSF_EXCEPTS
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_kbc9gk __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_kbc9gk* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_kbc9gk*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_kbc9gk Value
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

	unsafe static Llvm_libc_20_1_2_ACOSF_EXCEPTS()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_kbc9gk
		{
			Values = new InlineArrayBuilder<InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 847807907,
					Rnd_towardzero_result = 1070141402,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1299675741,
					Rnd_towardzero_result = 1070141402,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 964846114,
					Rnd_towardzero_result = 1070139316,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1182637534,
					Rnd_towardzero_result = 1070143488,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
