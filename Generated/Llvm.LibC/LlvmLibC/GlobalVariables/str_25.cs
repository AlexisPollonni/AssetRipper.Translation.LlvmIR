using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.25")]
[DemangledName(".str.25")]
internal static partial class str_25
{
	[FixedAddressValueType]
	private static InlineArray18_SByte __value;

	public unsafe static InlineArray18_SByte* Pointer => unchecked((InlineArray18_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray18_SByte Value
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

	unsafe static str_25()
	{
		Value = InlineArrayHelper.Create<InlineArray18_SByte, byte>("11920928955078125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
