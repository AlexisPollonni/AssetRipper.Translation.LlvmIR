using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.1.186")]
[DemangledName(".str.1.186")]
internal static partial class str_1_186
{
	[FixedAddressValueType]
	private static InlineArray15_SByte __value;

	public unsafe static InlineArray15_SByte* Pointer => unchecked((InlineArray15_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray15_SByte Value
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

	unsafe static str_1_186()
	{
		Value = InlineArrayHelper.Create<InlineArray15_SByte, byte>("Unknown signal\0"u8);
		PointerIndices.Register(Pointer);
	}
}
