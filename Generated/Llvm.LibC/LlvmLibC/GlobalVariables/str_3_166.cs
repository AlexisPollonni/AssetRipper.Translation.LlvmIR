using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.3.166")]
[DemangledName(".str.3.166")]
internal static partial class str_3_166
{
	[FixedAddressValueType]
	private static InlineArray4_SByte __value;

	public unsafe static InlineArray4_SByte* Pointer => unchecked((InlineArray4_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_SByte Value
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

	unsafe static str_3_166()
	{
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>("NAN\0"u8);
		PointerIndices.Register(Pointer);
	}
}
