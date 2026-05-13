using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.36")]
[DemangledName(".str.36")]
internal static partial class str_36
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

	unsafe static str_36()
	{
		Value = InlineArrayHelper.Create<InlineArray25_SByte, byte>("582076609134674072265625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
