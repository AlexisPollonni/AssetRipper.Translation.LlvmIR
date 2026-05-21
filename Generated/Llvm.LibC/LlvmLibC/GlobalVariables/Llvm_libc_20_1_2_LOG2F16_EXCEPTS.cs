using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L15LOG2F16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::LOG2F16_EXCEPTS")]
internal static partial class Llvm_libc_20_1_2_LOG2F16_EXCEPTS
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_fkx7qf __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_fkx7qf* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_fkx7qf*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_fkx7qf Value
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

	unsafe static Llvm_libc_20_1_2_LOG2F16_EXCEPTS()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_fkx7qf
		{
			Values = new InlineArrayBuilder<InlineArray9_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 14473,
					Rnd_towardzero_result = -17779,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15245,
					Rnd_towardzero_result = -21162,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15267,
					Rnd_towardzero_result = -21430,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15334,
					Rnd_towardzero_result = -23368,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15339,
					Rnd_towardzero_result = -23652,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15341,
					Rnd_towardzero_result = -23838,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15355,
					Rnd_towardzero_result = -25800,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15359,
					Rnd_towardzero_result = -28219,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 15497,
					Rnd_towardzero_result = 12747,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
