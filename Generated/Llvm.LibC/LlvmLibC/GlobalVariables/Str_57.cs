using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.57")]
[DemangledName(".str.57")]
internal static partial class Str_57
{
	[FixedAddressValueType]
	private static InlineArray40_SByte __value;

	public unsafe static InlineArray40_SByte* Pointer => unchecked((InlineArray40_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray40_SByte Value
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

	unsafe static Str_57()
	{
		Value = InlineArrayHelper.Create<InlineArray40_SByte, byte>("277555756156289135105907917022705078125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
