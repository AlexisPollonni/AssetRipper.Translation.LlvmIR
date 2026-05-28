using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.51")]
[DemangledName(".str.51")]
internal static partial class Str_51
{
	[FixedAddressValueType]
	private static InlineArray36_SByte __value;

	public unsafe static InlineArray36_SByte* Pointer => unchecked((InlineArray36_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray36_SByte Value
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

	unsafe static Str_51()
	{
		Value = InlineArrayHelper.Create<InlineArray36_SByte, byte>("17763568394002504646778106689453125\0"u8);
		_ = Pointer;
	}
}
