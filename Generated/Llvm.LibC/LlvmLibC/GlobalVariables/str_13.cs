using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.13")]
[DemangledName(".str.13")]
internal static partial class str_13
{
	[FixedAddressValueType]
	private static InlineArray9_SByte __value;

	public unsafe static InlineArray9_SByte* Pointer => unchecked((InlineArray9_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray9_SByte Value
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

	unsafe static str_13()
	{
		Value = InlineArrayHelper.Create<InlineArray9_SByte, byte>("48828125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
