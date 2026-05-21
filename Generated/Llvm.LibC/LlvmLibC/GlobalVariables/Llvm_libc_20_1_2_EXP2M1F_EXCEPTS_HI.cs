using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L18EXP2M1F_EXCEPTS_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXP2M1F_EXCEPTS_HI")]
internal static partial class Llvm_libc_20_1_2_EXP2M1F_EXCEPTS_HI
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_evg4xu __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_evg4xu* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_evg4xu*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_evg4xu Value
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

	unsafe static Llvm_libc_20_1_2_EXP2M1F_EXCEPTS_HI()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_evg4xu
		{
			Values = new InlineArrayBuilder<InlineArray3_Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = 1057707193,
					Rnd_towardzero_result = 1055564505,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1118860970,
					Rnd_towardzero_result = -1123198138,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Llvm_libc_20_1_2_fputil_ExceptValues_float_6_Mapping
				{
					Input = -1116783154,
					Rnd_towardzero_result = -1121811334,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
