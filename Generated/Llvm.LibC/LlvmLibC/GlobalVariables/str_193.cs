using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.193")]
[DemangledName(".str.193")]
internal static partial class str_193
{
	[FixedAddressValueType]
	private static InlineArray14_SByte __value;

	public unsafe static InlineArray14_SByte* Pointer => unchecked((InlineArray14_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray14_SByte Value
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

	unsafe static str_193()
	{
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("Unknown error\0"u8);
		PointerIndices.Register(Pointer);
	}
}
