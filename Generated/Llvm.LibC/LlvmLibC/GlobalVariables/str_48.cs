using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.48")]
[DemangledName(".str.48")]
internal static partial class str_48
{
	[FixedAddressValueType]
	private static InlineArray34_SByte __value;

	public unsafe static InlineArray34_SByte* Pointer => unchecked((InlineArray34_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray34_SByte Value
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

	unsafe static str_48()
	{
		Value = InlineArrayHelper.Create<InlineArray34_SByte, byte>("142108547152020037174224853515625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
