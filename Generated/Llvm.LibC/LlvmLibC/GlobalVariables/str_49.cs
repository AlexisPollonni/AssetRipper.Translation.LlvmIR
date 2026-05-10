using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.49")]
[DemangledName(".str.49")]
internal static partial class str_49
{
	[FixedAddressValueType]
	private static InlineArray34_SByte __value;

	public unsafe static InlineArray34_SByte* Pointer => unchecked((InlineArray34_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray34_SByte Value
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

	unsafe static str_49()
	{
		Value = InlineArrayHelper.Create<InlineArray34_SByte, byte>("710542735760100185871124267578125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
