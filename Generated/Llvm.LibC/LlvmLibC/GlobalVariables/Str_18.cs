using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.18")]
[DemangledName(".str.18")]
internal static partial class Str_18
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

	unsafe static Str_18()
	{
		Value = InlineArrayHelper.Create<InlineArray13_SByte, byte>("152587890625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
