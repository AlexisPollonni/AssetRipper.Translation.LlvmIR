using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.59.129")]
[DemangledName(".str.59.129")]
internal static partial class str_59_129
{
	[FixedAddressValueType]
	private static InlineArray41_SByte __value;

	public unsafe static InlineArray41_SByte* Pointer => unchecked((InlineArray41_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray41_SByte Value
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

	unsafe static str_59_129()
	{
		Value = InlineArrayHelper.Create<InlineArray41_SByte, byte>("6938893903907228377647697925567626953125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
