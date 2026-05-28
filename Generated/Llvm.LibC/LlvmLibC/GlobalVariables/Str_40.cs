using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.40")]
[DemangledName(".str.40")]
internal static partial class Str_40
{
	[FixedAddressValueType]
	private static InlineArray28_SByte __value;

	public unsafe static InlineArray28_SByte* Pointer => unchecked((InlineArray28_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray28_SByte Value
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

	unsafe static Str_40()
	{
		Value = InlineArrayHelper.Create<InlineArray28_SByte, byte>("363797880709171295166015625\0"u8);
		_ = Pointer;
	}
}
