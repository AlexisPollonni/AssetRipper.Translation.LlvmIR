using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.45")]
[DemangledName(".str.45")]
internal static partial class Str_45
{
	[FixedAddressValueType]
	private static InlineArray32_SByte __value;

	public unsafe static InlineArray32_SByte* Pointer => unchecked((InlineArray32_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray32_SByte Value
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

	unsafe static Str_45()
	{
		Value = InlineArrayHelper.Create<InlineArray32_SByte, byte>("1136868377216160297393798828125\0"u8);
		_ = Pointer;
	}
}
