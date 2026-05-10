using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.37")]
[DemangledName(".str.37")]
internal static partial class str_37
{
	[FixedAddressValueType]
	private static InlineArray26_SByte __value;

	public unsafe static InlineArray26_SByte* Pointer => unchecked((InlineArray26_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray26_SByte Value
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

	unsafe static str_37()
	{
		Value = InlineArrayHelper.Create<InlineArray26_SByte, byte>("2910383045673370361328125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
