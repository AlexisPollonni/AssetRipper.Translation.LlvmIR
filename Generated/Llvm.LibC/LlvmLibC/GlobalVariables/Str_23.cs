using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.23")]
[DemangledName(".str.23")]
internal static partial class Str_23
{
	[FixedAddressValueType]
	private static InlineArray16_SByte __value;

	public unsafe static InlineArray16_SByte* Pointer => unchecked((InlineArray16_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray16_SByte Value
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

	unsafe static Str_23()
	{
		Value = InlineArrayHelper.Create<InlineArray16_SByte, byte>("476837158203125\0"u8);
		_ = Pointer;
	}
}
