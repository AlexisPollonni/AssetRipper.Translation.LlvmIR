using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.44")]
[DemangledName(".str.44")]
internal static partial class Str_44
{
	[FixedAddressValueType]
	private static InlineArray31_SByte __value;

	public unsafe static InlineArray31_SByte* Pointer => unchecked((InlineArray31_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray31_SByte Value
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

	unsafe static Str_44()
	{
		Value = InlineArrayHelper.Create<InlineArray31_SByte, byte>("227373675443232059478759765625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
