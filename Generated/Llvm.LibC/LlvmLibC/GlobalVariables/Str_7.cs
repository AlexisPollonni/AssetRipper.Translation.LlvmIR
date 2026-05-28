using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.7")]
[DemangledName(".str.7")]
internal static partial class Str_7
{
	[FixedAddressValueType]
	private static InlineArray5_SByte __value;

	public unsafe static InlineArray5_SByte* Pointer => unchecked((InlineArray5_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray5_SByte Value
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

	unsafe static Str_7()
	{
		Value = InlineArrayHelper.Create<InlineArray5_SByte, byte>("3125\0"u8);
		_ = Pointer;
	}
}
