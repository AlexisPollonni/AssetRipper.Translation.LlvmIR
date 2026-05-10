using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.24")]
[DemangledName(".str.24")]
internal static partial class str_24
{
	[FixedAddressValueType]
	private static InlineArray17_SByte __value;

	public unsafe static InlineArray17_SByte* Pointer => unchecked((InlineArray17_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray17_SByte Value
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

	unsafe static str_24()
	{
		Value = InlineArrayHelper.Create<InlineArray17_SByte, byte>("2384185791015625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
