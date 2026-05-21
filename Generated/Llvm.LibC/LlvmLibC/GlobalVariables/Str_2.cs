using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.2")]
[DemangledName(".str.2")]
internal static partial class Str_2
{
	[FixedAddressValueType]
	private static InlineArray42_SByte __value;

	public unsafe static InlineArray42_SByte* Pointer => unchecked((InlineArray42_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray42_SByte Value
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

	unsafe static Str_2()
	{
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("0x0000'0000'0000'03FF'FFFF'FFFF'FFFF'FFF0\0"u8);
		PointerIndices.Register(Pointer);
	}
}
