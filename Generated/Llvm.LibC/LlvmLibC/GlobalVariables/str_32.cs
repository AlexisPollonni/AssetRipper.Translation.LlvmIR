using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.32")]
[DemangledName(".str.32")]
internal static partial class str_32
{
	[FixedAddressValueType]
	private static InlineArray22_SByte __value;

	public unsafe static InlineArray22_SByte* Pointer => unchecked((InlineArray22_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray22_SByte Value
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

	unsafe static str_32()
	{
		Value = InlineArrayHelper.Create<InlineArray22_SByte, byte>("931322574615478515625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
