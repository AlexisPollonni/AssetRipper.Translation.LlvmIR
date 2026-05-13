using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.17")]
[DemangledName(".str.17")]
internal static partial class str_17
{
	[FixedAddressValueType]
	private static InlineArray12_SByte __value;

	public unsafe static InlineArray12_SByte* Pointer => unchecked((InlineArray12_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray12_SByte Value
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

	unsafe static str_17()
	{
		Value = InlineArrayHelper.Create<InlineArray12_SByte, byte>("30517578125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
