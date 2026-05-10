using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.19")]
[DemangledName(".str.19")]
internal static partial class str_19
{
	[FixedAddressValueType]
	private static InlineArray13_SByte __value;

	public unsafe static InlineArray13_SByte* Pointer => unchecked((InlineArray13_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray13_SByte Value
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

	unsafe static str_19()
	{
		Value = InlineArrayHelper.Create<InlineArray13_SByte, byte>("762939453125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
