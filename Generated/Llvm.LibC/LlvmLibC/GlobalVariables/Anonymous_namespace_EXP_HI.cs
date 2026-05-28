using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16EXP_HIE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::EXP_HI")]
internal static partial class Anonymous_namespace_EXP_HI
{
	[FixedAddressValueType]
	private static InlineArray24_Int32 __value;

	public unsafe static InlineArray24_Int32* Pointer => unchecked((InlineArray24_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray24_Int32 Value
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

	unsafe static Anonymous_namespace_EXP_HI()
	{
		Value = InlineArrayHelper.Create<InlineArray24_Int32, int>(new int[24]
		{
			1, 1, 4, 11, 30, 81, 221, 600, 1631, 4435,
			12055, 32768, 89073, 242125, 658163, 1789072, 4863202, 13219555, 35934475, 97680031,
			265521854, 721763231, 1961955876, 2147483647
		});
		_ = Pointer;
	}
}
