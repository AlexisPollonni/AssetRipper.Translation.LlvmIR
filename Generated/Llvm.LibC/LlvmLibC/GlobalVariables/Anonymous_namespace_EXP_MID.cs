using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_17EXP_MIDE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::EXP_MID")]
internal static partial class Anonymous_namespace_EXP_MID
{
	[FixedAddressValueType]
	private static InlineArray16_Int32 __value;

	public unsafe static InlineArray16_Int32* Pointer => unchecked((InlineArray16_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray16_Int32 Value
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

	unsafe static Anonymous_namespace_EXP_MID()
	{
		Value = InlineArrayHelper.Create<InlineArray16_Int32, int>(new int[16]
		{
			30783, 32768, 34881, 37131, 39526, 42075, 44789, 47677, 50752, 54025,
			57510, 61219, 65167, 69370, 73844, 78606
		});
		_ = Pointer;
	}
}
