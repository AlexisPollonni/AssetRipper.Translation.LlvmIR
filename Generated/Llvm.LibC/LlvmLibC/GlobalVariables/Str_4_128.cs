using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.4.128")]
[DemangledName(".str.4.128")]
internal static partial class Str_4_128
{
	[FixedAddressValueType]
	private static InlineArray3_SByte __value;

	public unsafe static InlineArray3_SByte* Pointer => unchecked((InlineArray3_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray3_SByte Value
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

	unsafe static Str_4_128()
	{
		Value = InlineArrayHelper.Create<InlineArray3_SByte, byte>("25\0"u8);
		PointerIndices.Register(Pointer);
	}
}
