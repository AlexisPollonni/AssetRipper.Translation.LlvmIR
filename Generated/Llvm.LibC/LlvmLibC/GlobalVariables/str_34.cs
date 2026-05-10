using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.34")]
[DemangledName(".str.34")]
internal static partial class str_34
{
	[FixedAddressValueType]
	private static InlineArray24_SByte __value;

	public unsafe static InlineArray24_SByte* Pointer => unchecked((InlineArray24_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray24_SByte Value
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

	unsafe static str_34()
	{
		Value = InlineArrayHelper.Create<InlineArray24_SByte, byte>("23283064365386962890625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
