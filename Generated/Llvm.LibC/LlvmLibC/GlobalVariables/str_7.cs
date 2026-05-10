using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.7")]
[DemangledName(".str.7")]
internal static partial class str_7
{
	[FixedAddressValueType]
	private static InlineArray5_SByte __value;

	public unsafe static InlineArray5_SByte* Pointer => unchecked((InlineArray5_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray5_SByte Value
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

	unsafe static str_7()
	{
		Value = InlineArrayHelper.Create<InlineArray5_SByte, byte>("3125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
