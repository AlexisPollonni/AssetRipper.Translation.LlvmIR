using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.27")]
[DemangledName(".str.27")]
internal static partial class Str_27
{
	[FixedAddressValueType]
	private static InlineArray19_SByte __value;

	public unsafe static InlineArray19_SByte* Pointer => unchecked((InlineArray19_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray19_SByte Value
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

	unsafe static Str_27()
	{
		Value = InlineArrayHelper.Create<InlineArray19_SByte, byte>("298023223876953125\0"u8);
		_ = Pointer;
	}
}
