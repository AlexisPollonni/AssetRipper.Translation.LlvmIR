using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str")]
[DemangledName(".str")]
internal static partial class Str
{
	[FixedAddressValueType]
	private static InlineArray38_SByte __value;

	public unsafe static InlineArray38_SByte* Pointer => unchecked((InlineArray38_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray38_SByte Value
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

	unsafe static Str()
	{
		Value = InlineArrayHelper.Create<InlineArray38_SByte, byte>("0x80000000'00000000'00000000'00000000\0"u8);
		_ = Pointer;
	}
}
