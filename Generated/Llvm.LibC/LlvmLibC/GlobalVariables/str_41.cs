using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.41")]
[DemangledName(".str.41")]
internal static partial class str_41
{
	[FixedAddressValueType]
	private static InlineArray29_SByte __value;

	public unsafe static InlineArray29_SByte* Pointer => unchecked((InlineArray29_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray29_SByte Value
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

	unsafe static str_41()
	{
		Value = InlineArrayHelper.Create<InlineArray29_SByte, byte>("1818989403545856475830078125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
