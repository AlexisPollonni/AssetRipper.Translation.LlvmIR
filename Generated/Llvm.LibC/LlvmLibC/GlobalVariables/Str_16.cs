using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.16")]
[DemangledName(".str.16")]
internal static partial class Str_16
{
	[FixedAddressValueType]
	private static InlineArray11_SByte __value;

	public unsafe static InlineArray11_SByte* Pointer => unchecked((InlineArray11_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray11_SByte Value
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

	unsafe static Str_16()
	{
		Value = InlineArrayHelper.Create<InlineArray11_SByte, byte>("6103515625\0"u8);
		_ = Pointer;
	}
}
