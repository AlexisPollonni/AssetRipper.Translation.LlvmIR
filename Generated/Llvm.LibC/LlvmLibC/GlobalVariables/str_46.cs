using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.46")]
[DemangledName(".str.46")]
internal static partial class str_46
{
	[FixedAddressValueType]
	private static InlineArray32_SByte __value;

	public unsafe static InlineArray32_SByte* Pointer => unchecked((InlineArray32_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray32_SByte Value
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

	unsafe static str_46()
	{
		Value = InlineArrayHelper.Create<InlineArray32_SByte, byte>("5684341886080801486968994140625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
