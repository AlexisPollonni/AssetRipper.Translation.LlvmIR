using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.59.127")]
[DemangledName(".str.59.127")]
internal static partial class str_59_127
{
	[FixedAddressValueType]
	private static InlineArray41_SByte __value;

	public unsafe static InlineArray41_SByte* Pointer => unchecked((InlineArray41_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray41_SByte Value
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

	unsafe static str_59_127()
	{
		Value = InlineArrayHelper.Create<InlineArray41_SByte, byte>("6938893903907228377647697925567626953125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
