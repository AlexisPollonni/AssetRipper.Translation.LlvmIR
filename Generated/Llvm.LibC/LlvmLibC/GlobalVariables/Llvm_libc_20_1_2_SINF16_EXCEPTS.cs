using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L14SINF16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::SINF16_EXCEPTS")]
internal static partial class Llvm_libc_20_1_2_SINF16_EXCEPTS
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_pfsijn __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_pfsijn* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_pfsijn*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_pfsijn Value
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

	unsafe static Llvm_libc_20_1_2_SINF16_EXCEPTS()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_pfsijn
		{
			Values = new InlineArrayBuilder<InlineArray4_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 11077,
					Rnd_towardzero_result = 11075,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 22620,
					Rnd_towardzero_result = 15267,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 23728,
					Rnd_towardzero_result = -17409,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 20981,
					Rnd_towardzero_result = -18417,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
