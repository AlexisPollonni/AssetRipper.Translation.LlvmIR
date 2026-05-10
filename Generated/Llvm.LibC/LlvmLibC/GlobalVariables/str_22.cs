using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.22")]
[DemangledName(".str.22")]
internal static partial class str_22
{
	[FixedAddressValueType]
	private static InlineArray15_SByte __value;

	public unsafe static InlineArray15_SByte* Pointer => unchecked((InlineArray15_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray15_SByte Value
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

	unsafe static str_22()
	{
		Value = InlineArrayHelper.Create<InlineArray15_SByte, byte>("95367431640625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
