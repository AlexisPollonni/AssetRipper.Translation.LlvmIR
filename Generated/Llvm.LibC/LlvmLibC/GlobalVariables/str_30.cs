using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.30")]
[DemangledName(".str.30")]
internal static partial class str_30
{
	[FixedAddressValueType]
	private static InlineArray21_SByte __value;

	public unsafe static InlineArray21_SByte* Pointer => unchecked((InlineArray21_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray21_SByte Value
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

	unsafe static str_30()
	{
		Value = InlineArrayHelper.Create<InlineArray21_SByte, byte>("37252902984619140625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
