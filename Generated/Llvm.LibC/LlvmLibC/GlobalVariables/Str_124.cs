using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.124")]
[DemangledName(".str.124")]
internal static partial class Str_124
{
	[FixedAddressValueType]
	private static InlineArray9_SByte __value;

	public unsafe static InlineArray9_SByte* Pointer => unchecked((InlineArray9_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray9_SByte Value
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

	unsafe static Str_124()
	{
		Value = InlineArrayHelper.Create<InlineArray9_SByte, byte>("infinity\0"u8);
		_ = Pointer;
	}
}
