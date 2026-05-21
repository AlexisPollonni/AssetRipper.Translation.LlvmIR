using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.5")]
[DemangledName(".str.5")]
internal static partial class Str_5
{
	[FixedAddressValueType]
	private static InlineArray4_SByte __value;

	public unsafe static InlineArray4_SByte* Pointer => unchecked((InlineArray4_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_SByte Value
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

	unsafe static Str_5()
	{
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>("125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
