using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.3")]
[DemangledName(".str.3")]
internal static partial class Str_3
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

	unsafe static Str_3()
	{
		Value = InlineArrayHelper.Create<InlineArray42_SByte, byte>("0xFFFF'FFFF'FFFF'FFFF'FFFF'FFFF'FFFF'FFF0\0"u8);
		_ = Pointer;
	}
}
