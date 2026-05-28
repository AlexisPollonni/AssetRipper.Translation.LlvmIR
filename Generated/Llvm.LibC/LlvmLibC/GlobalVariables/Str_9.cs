using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.9")]
[DemangledName(".str.9")]
internal static partial class Str_9
{
	[FixedAddressValueType]
	private static InlineArray6_SByte __value;

	public unsafe static InlineArray6_SByte* Pointer => unchecked((InlineArray6_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray6_SByte Value
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

	unsafe static Str_9()
	{
		Value = InlineArrayHelper.Create<InlineArray6_SByte, byte>("78125\0"u8);
		_ = Pointer;
	}
}
