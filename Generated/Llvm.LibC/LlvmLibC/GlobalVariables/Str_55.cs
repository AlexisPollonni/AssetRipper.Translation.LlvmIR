using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.55")]
[DemangledName(".str.55")]
internal static partial class Str_55
{
	[FixedAddressValueType]
	private static InlineArray39_SByte __value;

	public unsafe static InlineArray39_SByte* Pointer => unchecked((InlineArray39_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray39_SByte Value
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

	unsafe static Str_55()
	{
		Value = InlineArrayHelper.Create<InlineArray39_SByte, byte>("11102230246251565404236316680908203125\0"u8);
		_ = Pointer;
	}
}
