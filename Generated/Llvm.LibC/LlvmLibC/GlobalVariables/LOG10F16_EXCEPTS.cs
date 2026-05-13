using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L16LOG10F16_EXCEPTSE")]
[DemangledName("__llvm_libc_20_1_2_::LOG10F16_EXCEPTS")]
internal static partial class LOG10F16_EXCEPTS
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_dwtyzi __value;

	public unsafe static fputil_ExceptValues_dwtyzi* Pointer => unchecked((fputil_ExceptValues_dwtyzi*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_dwtyzi Value
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

	unsafe static LOG10F16_EXCEPTS()
	{
		Value = new fputil_ExceptValues_dwtyzi
		{
			values = new InlineArrayBuilder<InlineArray11_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 13199,
					rnd_towardzero_result = -18173,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 13304,
					rnd_towardzero_result = -18220,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 15274,
					rnd_towardzero_result = -23356,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 15276,
					rnd_towardzero_result = -23385,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 15308,
					rnd_towardzero_result = -24137,
					rnd_upward_offset = 0,
					rnd_downward_offset = 1,
					rnd_tonearest_offset = 1
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 18688,
					rnd_towardzero_result = 15360,
					rnd_upward_offset = 0,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 22080,
					rnd_towardzero_result = 16384,
					rnd_upward_offset = 0,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 22497,
					rnd_towardzero_result = 16435,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 25552,
					rnd_towardzero_result = 16896,
					rnd_upward_offset = 0,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 28898,
					rnd_towardzero_result = 17408,
					rnd_upward_offset = 0,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				},
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 29085,
					rnd_towardzero_result = 17423,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 0
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
