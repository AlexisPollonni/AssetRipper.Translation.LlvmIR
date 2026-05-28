using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L12TANF_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::TANF_EXCEPTS")]
internal static partial class TANF_EXCEPTS
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

	unsafe static TANF_EXCEPTS()
	{
		Value = new Fputil_ExceptValues_7xi2jk
		{
			Values = new InlineArrayBuilder<InlineArray6_Fputil_ExceptValues_float_6_Mapping, Fputil_ExceptValues_float_6_Mapping>
			{
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1297535829,
					Rnd_towardzero_result = 1047789954,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1346572338,
					Rnd_towardzero_result = -1102645461,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1473753325,
					Rnd_towardzero_result = 1051748579,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1501578334,
					Rnd_towardzero_result = 1071976296,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1677494014,
					Rnd_towardzero_result = 1059897294,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 0
				},
				new Fputil_ExceptValues_float_6_Mapping
				{
					Input = 1792239369,
					Rnd_towardzero_result = -1084051305,
					Rnd_upward_offset = 0,
					Rnd_downward_offset = 1,
					Rnd_tonearest_offset = 0
				}
			}
		};
		_ = Pointer;
	}
}
