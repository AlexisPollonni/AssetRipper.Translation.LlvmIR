using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.52")]
[DemangledName(".str.52")]
internal static partial class str_52
{
	[FixedAddressValueType]
	private static InlineArray36_SByte __value;

	public unsafe static InlineArray36_SByte* Pointer => unchecked((InlineArray36_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray36_SByte Value
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

	unsafe static str_52()
	{
		Value = InlineArrayHelper.Create<InlineArray36_SByte, byte>("88817841970012523233890533447265625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
