using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.10")]
[DemangledName(".str.10")]
internal static partial class str_10
{
	[FixedAddressValueType]
	private static InlineArray7_SByte __value;

	public unsafe static InlineArray7_SByte* Pointer => unchecked((InlineArray7_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray7_SByte Value
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

	unsafe static str_10()
	{
		Value = InlineArrayHelper.Create<InlineArray7_SByte, byte>("390625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
