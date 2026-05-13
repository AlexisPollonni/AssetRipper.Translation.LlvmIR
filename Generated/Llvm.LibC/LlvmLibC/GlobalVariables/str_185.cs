using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.185")]
[DemangledName(".str.185")]
internal static partial class str_185
{
	[FixedAddressValueType]
	private static InlineArray17_SByte __value;

	public unsafe static InlineArray17_SByte* Pointer => unchecked((InlineArray17_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray17_SByte Value
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

	unsafe static str_185()
	{
		Value = InlineArrayHelper.Create<InlineArray17_SByte, byte>("Real-time signal\0"u8);
		PointerIndices.Register(Pointer);
	}
}
