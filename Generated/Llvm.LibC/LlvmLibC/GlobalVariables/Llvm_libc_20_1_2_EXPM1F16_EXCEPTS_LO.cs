using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L19EXPM1F16_EXCEPTS_LOE")]
[DemangledName("__llvm_libc_20_1_2_::EXPM1F16_EXCEPTS_LO")]
internal static partial class Llvm_libc_20_1_2_EXPM1F16_EXCEPTS_LO
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_fputil_ExceptValues_yv4gxk __value;

	public unsafe static Llvm_libc_20_1_2_fputil_ExceptValues_yv4gxk* Pointer => unchecked((Llvm_libc_20_1_2_fputil_ExceptValues_yv4gxk*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_fputil_ExceptValues_yv4gxk Value
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

	unsafe static Llvm_libc_20_1_2_EXPM1F16_EXCEPTS_LO()
	{
		Value = new Llvm_libc_20_1_2_fputil_ExceptValues_yv4gxk
		{
			Values = new InlineArrayBuilder<InlineArray1_Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping, Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping>
			{
				new Llvm_libc_20_1_2_fputil_ExceptValues_Float16_21_Mapping
				{
					Input = 10585,
					Rnd_towardzero_result = 10613,
					Rnd_upward_offset = 1,
					Rnd_downward_offset = 0,
					Rnd_tonearest_offset = 1
				}
			}
		};
		PointerIndices.Register(Pointer);
	}
}
