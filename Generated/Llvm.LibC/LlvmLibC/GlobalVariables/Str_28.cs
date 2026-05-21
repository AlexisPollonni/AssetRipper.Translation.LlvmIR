using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.28")]
[DemangledName(".str.28")]
internal static partial class Str_28
{
	[FixedAddressValueType]
	private static InlineArray20_SByte __value;

	public unsafe static InlineArray20_SByte* Pointer => unchecked((InlineArray20_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray20_SByte Value
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

	unsafe static Str_28()
	{
		Value = InlineArrayHelper.Create<InlineArray20_SByte, byte>("1490116119384765625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
