using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.35")]
[DemangledName(".str.35")]
internal static partial class Str_35
{
	[FixedAddressValueType]
	private static InlineArray25_SByte __value;

	public unsafe static InlineArray25_SByte* Pointer => unchecked((InlineArray25_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray25_SByte Value
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

	unsafe static Str_35()
	{
		Value = InlineArrayHelper.Create<InlineArray25_SByte, byte>("116415321826934814453125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
