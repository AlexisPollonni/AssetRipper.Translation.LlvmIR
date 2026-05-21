using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L17EXPF16_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXPF16_EXCEPTS_LO")]
internal static partial class Llvm_libc_20_1_2_EXPF16_EXCEPTS_LO
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

	unsafe static Llvm_libc_20_1_2_EXPF16_EXCEPTS_LO()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_rhfsch
		{
			Values = new InlineArrayBuilder<InlineArray2_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 8057,
					Rnd_towardzero_result = 15367,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 9679,
					Rnd_towardzero_result = 15383,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
