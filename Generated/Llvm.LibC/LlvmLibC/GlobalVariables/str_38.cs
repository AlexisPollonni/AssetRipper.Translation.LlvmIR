using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.38")]
[DemangledName(".str.38")]
internal static partial class str_38
{
	[FixedAddressValueType]
	private static InlineArray27_SByte __value;

	public unsafe static InlineArray27_SByte* Pointer => unchecked((InlineArray27_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray27_SByte Value
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

	unsafe static str_38()
	{
		Value = InlineArrayHelper.Create<InlineArray27_SByte, byte>("14551915228366851806640625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
