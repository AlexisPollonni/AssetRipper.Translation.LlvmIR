using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.42")]
[DemangledName(".str.42")]
internal static partial class str_42
{
	[FixedAddressValueType]
	private static InlineArray29_SByte __value;

	public unsafe static InlineArray29_SByte* Pointer => unchecked((InlineArray29_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray29_SByte Value
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

	unsafe static str_42()
	{
		Value = InlineArrayHelper.Create<InlineArray29_SByte, byte>("9094947017729282379150390625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
