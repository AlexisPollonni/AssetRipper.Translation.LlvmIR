using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.11")]
[DemangledName(".str.11")]
internal static partial class str_11
{
	[FixedAddressValueType]
	private static InlineArray8_SByte __value;

	public unsafe static InlineArray8_SByte* Pointer => unchecked((InlineArray8_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray8_SByte Value
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

	unsafe static str_11()
	{
		Value = InlineArrayHelper.Create<InlineArray8_SByte, byte>("1953125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
