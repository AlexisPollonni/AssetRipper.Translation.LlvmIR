using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19EXPM1F16_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXPM1F16_EXCEPTS_HI")]
internal static partial class Llvm_libc_20_1_2_EXPM1F16_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_x8ns5m __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_x8ns5m* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_x8ns5m*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_x8ns5m Value
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

	unsafe static Llvm_libc_20_1_2_EXPM1F16_EXCEPTS_HI()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_x8ns5m
		{
			Values = new InlineArrayBuilder<InlineArray3_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 16141,
					Rnd_towardzero_result = 17619,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -19574,
					Rnd_towardzero_result = -19785,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 12930,
					Rnd_towardzero_result = 13111,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
