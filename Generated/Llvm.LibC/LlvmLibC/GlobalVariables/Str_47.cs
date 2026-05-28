using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.47")]
[DemangledName(".str.47")]
internal static partial class Str_47
{
	[FixedAddressValueType]
	private static InlineArray33_SByte __value;

	public unsafe static InlineArray33_SByte* Pointer => unchecked((InlineArray33_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray33_SByte Value
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

	unsafe static Str_47()
	{
		Value = InlineArrayHelper.Create<InlineArray33_SByte, byte>("28421709430404007434844970703125\0"u8);
		_ = Pointer;
	}
}
