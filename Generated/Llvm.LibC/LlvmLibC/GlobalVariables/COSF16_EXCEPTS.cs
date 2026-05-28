using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L14COSF16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::COSF16_EXCEPTS")]
internal static partial class COSF16_EXCEPTS
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_pfsijn __value;

	public unsafe static Fputil_ExceptValues_pfsijn* Pointer => unchecked((Fputil_ExceptValues_pfsijn*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_pfsijn Value
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

	unsafe static COSF16_EXCEPTS()
	{
		Value = new Fputil_ExceptValues_pfsijn
		{
			Values = new InlineArrayBuilder<InlineArray4_Fputil_ExceptValues_Float16_21_Mapping, Fputil_ExceptValues_Float16_21_Mapping>
			{
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 11132,
					Rnd_towardzero_result = 15356,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 19137,
					Rnd_towardzero_result = 14517,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 23625,
					Rnd_towardzero_result = -18234,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 31436,
					Rnd_towardzero_result = -23436,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
