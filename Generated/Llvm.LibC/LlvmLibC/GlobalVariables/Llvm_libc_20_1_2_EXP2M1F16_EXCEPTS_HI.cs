using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L20EXP2M1F16_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2M1F16_EXCEPTS_HI")]
internal static partial class Llvm_libc_20_1_2_EXP2M1F16_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_pcxpx6 __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_pcxpx6* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_pcxpx6*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_pcxpx6 Value
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

	unsafe static Llvm_libc_20_1_2_EXP2M1F16_EXCEPTS_HI()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_pcxpx6
		{
			Values = new InlineArrayBuilder<InlineArray7_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 13206,
					Rnd_towardzero_result = 12727,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 13498,
					Rnd_towardzero_result = 13125,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 14006,
					Rnd_towardzero_result = 13670,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -19967,
					Rnd_towardzero_result = -20531,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -19508,
					Rnd_towardzero_result = -20231,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -18267,
					Rnd_towardzero_result = -19124,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = -17779,
					Rnd_towardzero_result = -18707,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
