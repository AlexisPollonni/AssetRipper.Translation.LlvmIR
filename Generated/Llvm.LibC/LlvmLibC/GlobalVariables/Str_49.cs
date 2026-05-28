using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.49")]
[DemangledName(".str.49")]
internal static partial class Str_49
{
	[FixedAddressValueType]
	private static InlineArray34_SByte __value;

	public unsafe static InlineArray34_SByte* Pointer => unchecked((InlineArray34_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray34_SByte Value
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

	unsafe static Str_49()
	{
		Value = InlineArrayHelper.Create<InlineArray34_SByte, byte>("710542735760100185871124267578125\0"u8);
		_ = Pointer;
	}
}
