using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.56")]
[DemangledName(".str.56")]
internal static partial class Str_56
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

	unsafe static Str_56()
	{
		Value = InlineArrayHelper.Create<InlineArray39_SByte, byte>("55511151231257827021181583404541015625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
