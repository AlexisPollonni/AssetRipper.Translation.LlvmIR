using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.58")]
[DemangledName(".str.58")]
internal static partial class Str_58
{
	[FixedAddressValueType]
	private static InlineArray41_SByte __value;

	public unsafe static InlineArray41_SByte* Pointer => unchecked((InlineArray41_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray41_SByte Value
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

	unsafe static Str_58()
	{
		Value = InlineArrayHelper.Create<InlineArray41_SByte, byte>("1387778780781445675529539585113525390625\0"u8);
		_ = Pointer;
	}
}
