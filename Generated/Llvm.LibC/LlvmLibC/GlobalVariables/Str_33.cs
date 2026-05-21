using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.33")]
[DemangledName(".str.33")]
internal static partial class Str_33
{
	[FixedAddressValueType]
	private static InlineArray23_SByte __value;

	public unsafe static InlineArray23_SByte* Pointer => unchecked((InlineArray23_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray23_SByte Value
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

	unsafe static Str_33()
	{
		Value = InlineArrayHelper.Create<InlineArray23_SByte, byte>("4656612873077392578125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
