using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.1")]
[DemangledName(".str.1")]
internal static partial class Str_1
{
	[FixedAddressValueType]
	private static InlineArray42_SByte __value;

	public unsafe static InlineArray42_SByte* Pointer => unchecked((InlineArray42_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray42_SByte Value
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

	unsafe static Str_1()
	{
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("0x0000'0000'0000'0000'0000'0000'0000'000F\0"u8);
		PointerIndices.Register(Pointer);
	}
}
