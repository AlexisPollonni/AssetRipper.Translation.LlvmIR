using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.218")]
[DemangledName(".str.218")]
internal static partial class str_218
{
	[FixedAddressValueType]
	private static InlineArray12_SByte __value;

	public unsafe static InlineArray12_SByte* Pointer => unchecked((InlineArray12_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray12_SByte Value
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

	unsafe static str_218()
	{
		Value = InlineArrayHelper.Create<InlineArray12_SByte, byte>("unsupported\0"u8);
		PointerIndices.Register(Pointer);
	}
}
