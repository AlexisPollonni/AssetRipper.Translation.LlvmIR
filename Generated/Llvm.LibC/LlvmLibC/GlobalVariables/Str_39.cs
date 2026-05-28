using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.39")]
[DemangledName(".str.39")]
internal static partial class Str_39
{
	[FixedAddressValueType]
	private static InlineArray27_SByte __value;

	public unsafe static InlineArray27_SByte* Pointer => unchecked((InlineArray27_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray27_SByte Value
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

	unsafe static Str_39()
	{
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("72759576141834259033203125\0"u8);
		_ = Pointer;
	}
}
