using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L18EXP2M1F_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2M1F_EXCEPTS_LO")]
internal static partial class Llvm_libc_20_1_2_EXP2M1F_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_rejery __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_rejery* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_rejery*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_rejery Value
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

	unsafe static Llvm_libc_20_1_2_EXP2M1F_EXCEPTS_LO()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_rejery
		{
			Values = new InlineArrayBuilder<InlineArray8_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 765161031,
					Rnd_towardzero_result = 760707337,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 907093147,
					Rnd_towardzero_result = 902379015,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 904443536,
					Rnd_towardzero_result = 899763702,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 948685391,
					Rnd_towardzero_result = 943836032,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1395777777,
					Rnd_towardzero_result = -1399922858,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1348025126,
					Rnd_towardzero_result = -1352191781,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1160546974,
					Rnd_towardzero_result = -1164804755,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1124882121,
					Rnd_towardzero_result = -1129895441,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
