using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.50")]
[DemangledName(".str.50")]
internal static partial class str_50
{
	[FixedAddressValueType]
	private static InlineArray35_SByte __value;

	public unsafe static InlineArray35_SByte* Pointer => unchecked((InlineArray35_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray35_SByte Value
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

	unsafe static str_50()
	{
		Value = InlineArrayHelper.Create<InlineArray35_SByte, byte>("3552713678800500929355621337890625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
