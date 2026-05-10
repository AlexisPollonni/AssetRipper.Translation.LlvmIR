using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.4")]
[DemangledName(".str.4")]
internal static partial class str_4
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

	unsafe static str_4()
	{
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("0x8000'0000'0000'0000'0000'0000'0000'0000\0"u8);
		PointerIndices.Register(Pointer);
	}
}
