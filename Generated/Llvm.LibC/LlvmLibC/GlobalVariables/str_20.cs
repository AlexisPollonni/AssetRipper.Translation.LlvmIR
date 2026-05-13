using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.20")]
[DemangledName(".str.20")]
internal static partial class str_20
{
	[FixedAddressValueType]
	private static InlineArray14_SByte __value;

	public unsafe static InlineArray14_SByte* Pointer => unchecked((InlineArray14_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray14_SByte Value
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

	unsafe static str_20()
	{
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("3814697265625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
