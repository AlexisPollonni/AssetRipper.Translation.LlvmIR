using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.8")]
[DemangledName(".str.8")]
internal static partial class Str_8
{
	[FixedAddressValueType]
	private static InlineArray6_SByte __value;

	public unsafe static InlineArray6_SByte* Pointer => unchecked((InlineArray6_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray6_SByte Value
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

	unsafe static Str_8()
	{
		Value = InlineArrayHelper.Create<InlineArray6_SByte, byte>("15625\0"u8);
		PointerIndices.Register(Pointer);
	}
}
