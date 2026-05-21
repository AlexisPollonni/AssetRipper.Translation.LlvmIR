using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.111")]
[DemangledName(".str.111")]
internal static partial class Str_111
{
	[FixedAddressValueType]
	private static InlineArray2_SByte __value;

	public unsafe static InlineArray2_SByte* Pointer => unchecked((InlineArray2_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray2_SByte Value
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

	unsafe static Str_111()
	{
		Value = InlineArrayHelper.Create<InlineArray2_SByte, byte>(".\0"u8);
		PointerIndices.Register(Pointer);
	}
}
