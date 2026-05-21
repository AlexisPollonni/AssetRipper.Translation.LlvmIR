using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.26")]
[DemangledName(".str.26")]
internal static partial class Str_26
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

	unsafe static Str_26()
	{
		Value = InlineArrayHelper.Create<InlineArray18_SByte, byte>("59604644775390625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
