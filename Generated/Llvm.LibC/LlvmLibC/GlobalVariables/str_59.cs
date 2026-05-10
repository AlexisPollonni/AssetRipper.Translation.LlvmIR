using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.59")]
[DemangledName(".str.59")]
internal static partial class str_59
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

	unsafe static str_59()
	{
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("0x0000'0000'0000'03FF'FFFF'FFFF'FFFF'FFFF\0"u8);
		PointerIndices.Register(Pointer);
	}
}
