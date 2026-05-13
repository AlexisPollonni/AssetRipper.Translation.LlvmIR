using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.29")]
[DemangledName(".str.29")]
internal static partial class str_29
{
	[FixedAddressValueType]
	private static InlineArray20_SByte __value;

	public unsafe static InlineArray20_SByte* Pointer => unchecked((InlineArray20_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray20_SByte Value
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

	unsafe static str_29()
	{
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("7450580596923828125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
