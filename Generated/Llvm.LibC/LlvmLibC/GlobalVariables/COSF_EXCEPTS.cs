using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L12COSF_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::COSF_EXCEPTS")]
internal static partial class COSF_EXCEPTS
{
	[FixedAddressValueType]
	private static Fputil_ExceptValues_7xi2jk __value;

	public unsafe static Fputil_ExceptValues_7xi2jk* Pointer => unchecked((Fputil_ExceptValues_7xi2jk*)Unsafe.AsPointer(ref __value));

	public static Fputil_ExceptValues_7xi2jk Value
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

	unsafe static COSF_EXCEPTS()
	{
		Value = new Fputil_ExceptValues_7xi2jk
		{
			Values = new InlineArrayBuilder<InlineArray6_Fputil_ExceptValues_float_6_Mapping, Fputil_ExceptValues_float_6_Mapping>
			{
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1429360665,
					Rnd_towardzero_result = 1062118866,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1495444096,
					Rnd_towardzero_result = 1057533630,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1520718892,
					Rnd_towardzero_result = 1056587940,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1595455608,
					Rnd_towardzero_result = 1065292987,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1628818193,
					Rnd_towardzero_result = 1064834094,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 2079258095,
					Rnd_towardzero_result = 1057530396,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
