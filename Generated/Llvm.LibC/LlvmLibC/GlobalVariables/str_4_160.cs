using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.4.160")]
[DemangledName(".str.4.160")]
internal static partial class str_4_160
{
	[FixedAddressValueType]
	private static InlineArray2_SByte __value;

	public unsafe static InlineArray2_SByte* Pointer => unchecked((InlineArray2_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray2_SByte Value
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

	unsafe static str_4_160()
	{
		Value = InlineArrayHelper.Create<InlineArray2_SByte, byte>(".\0"u8);
		PointerIndices.Register(Pointer);
	}
}
