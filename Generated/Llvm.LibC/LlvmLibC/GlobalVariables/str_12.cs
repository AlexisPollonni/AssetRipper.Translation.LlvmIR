using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.12")]
[DemangledName(".str.12")]
internal static partial class str_12
{
	[FixedAddressValueType]
	private static InlineArray8_SByte __value;

	public unsafe static InlineArray8_SByte* Pointer => unchecked((InlineArray8_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray8_SByte Value
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

	unsafe static str_12()
	{
		Value = InlineArrayHelper.Create<InlineArray8_SByte, byte>("9765625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
