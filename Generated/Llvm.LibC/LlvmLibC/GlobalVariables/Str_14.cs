using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.14")]
[DemangledName(".str.14")]
internal static partial class Str_14
{
	[FixedAddressValueType]
	private static InlineArray10_SByte __value;

	public unsafe static InlineArray10_SByte* Pointer => unchecked((InlineArray10_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray10_SByte Value
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

	unsafe static Str_14()
	{
		Value = InlineArrayHelper.Create<InlineArray10_SByte, byte>("244140625\0"u8);
		_ = Pointer;
	}
}
