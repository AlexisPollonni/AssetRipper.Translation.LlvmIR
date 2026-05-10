using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.47")]
[DemangledName(".str.47")]
internal static partial class str_47
{
	[FixedAddressValueType]
	private static InlineArray33_SByte __value;

	public unsafe static InlineArray33_SByte* Pointer => unchecked((InlineArray33_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray33_SByte Value
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

	unsafe static str_47()
	{
		Value = InlineArrayHelper.Create<InlineArray33_SByte, byte>("28421709430404007434844970703125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
