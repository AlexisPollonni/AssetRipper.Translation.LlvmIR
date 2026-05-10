using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.4.126")]
[DemangledName(".str.4.126")]
internal static partial class str_4_126
{
	[FixedAddressValueType]
	private static InlineArray3_SByte __value;

	public unsafe static InlineArray3_SByte* Pointer => unchecked((InlineArray3_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray3_SByte Value
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

	unsafe static str_4_126()
	{
		Value = InlineArrayHelper.Create<InlineArray3_SByte, byte>("25\0"u8);
		PointerIndices.Register(Pointer);
	}
}
