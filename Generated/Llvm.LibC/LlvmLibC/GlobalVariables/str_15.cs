using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.15")]
[DemangledName(".str.15")]
internal static partial class str_15
{
	[FixedAddressValueType]
	private static InlineArray11_SByte __value;

	public unsafe static InlineArray11_SByte* Pointer => unchecked((InlineArray11_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray11_SByte Value
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

	unsafe static str_15()
	{
		Value = InlineArrayHelper.Create<InlineArray11_SByte, byte>("1220703125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
