using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.54")]
[DemangledName(".str.54")]
internal static partial class Str_54
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

	unsafe static Str_54()
	{
		Value = InlineArrayHelper.Create<InlineArray38_SByte, byte>("2220446049250313080847263336181640625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
