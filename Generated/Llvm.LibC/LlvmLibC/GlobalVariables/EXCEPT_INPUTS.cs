using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L13EXCEPT_INPUTSE")]
[DemangledName("__llvm_libc_20_1_2_::EXCEPT_INPUTS")]
internal static partial class EXCEPT_INPUTS
{
	[FixedAddressValueType]
	private static InlineArray6_Int32 __value;

	public unsafe static InlineArray6_Int32* Pointer => unchecked((InlineArray6_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray6_Int32 Value
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

	unsafe static EXCEPT_INPUTS()
	{
		Value = InlineArrayHelper.Create<InlineArray6_Int32, int>(new int[6] { 1176082840, 1429360665, 1495444096, 1595455608, 1628818193, 2079258095 });
		PointerIndices.Register(Pointer);
	}
}
