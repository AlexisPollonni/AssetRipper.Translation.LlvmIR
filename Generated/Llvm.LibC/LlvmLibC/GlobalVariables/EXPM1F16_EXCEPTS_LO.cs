using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19EXPM1F16_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXPM1F16_EXCEPTS_LO")]
internal static partial class EXPM1F16_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static fputil_ExceptValues_yv4gxk __value;

	public unsafe static fputil_ExceptValues_yv4gxk* Pointer => unchecked((fputil_ExceptValues_yv4gxk*)Unsafe.AsPointer(ref __value));

	public static fputil_ExceptValues_yv4gxk Value
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

	unsafe static EXPM1F16_EXCEPTS_LO()
	{
		Value = new fputil_ExceptValues_yv4gxk
		{
			values = new InlineArrayBuilder<InlineArray1_fputil_ExceptValues_Float16_21_Mapping, fputil_ExceptValues_Float16_21_Mapping>
			{
				new fputil_ExceptValues_Float16_21_Mapping
				{
					input = 10585,
					rnd_towardzero_result = 10613,
					rnd_upward_offset = 1,
					rnd_downward_offset = 0,
					rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
