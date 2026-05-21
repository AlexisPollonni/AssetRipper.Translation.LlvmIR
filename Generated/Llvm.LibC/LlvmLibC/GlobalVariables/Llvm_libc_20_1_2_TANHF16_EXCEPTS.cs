using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L15TANHF16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::TANHF16_EXCEPTS")]
internal static partial class Llvm_libc_20_1_2_TANHF16_EXCEPTS
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_rhfsch __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_rhfsch* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_rhfsch*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_rhfsch Value
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

	unsafe static Llvm_libc_20_1_2_TANHF16_EXCEPTS()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_rhfsch
		{
			Values = new InlineArrayBuilder<InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 16341,
					Rnd_towardzero_result = 15280,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -16427,
					Rnd_towardzero_result = -17488,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
