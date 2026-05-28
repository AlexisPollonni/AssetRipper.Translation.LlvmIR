using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.31")]
[DemangledName(".str.31")]
internal static partial class Str_31
{
	[FixedAddressValueType]
	private static InlineArray22_SByte __value;

	public unsafe static InlineArray22_SByte* Pointer => unchecked((InlineArray22_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray22_SByte Value
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

	unsafe static Str_31()
	{
		Value = InlineArrayHelper.Create<InlineArray22_SByte, byte>("186264514923095703125\0"u8);
		_ = Pointer;
	}
}
