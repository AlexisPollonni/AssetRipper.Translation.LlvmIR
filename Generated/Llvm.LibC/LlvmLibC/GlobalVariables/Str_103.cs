using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.103")]
[DemangledName(".str.103")]
internal static partial class Str_103
{
	[FixedAddressValueType]
	private static InlineArray16_SByte __value;

	public unsafe static InlineArray16_SByte* Pointer => unchecked((InlineArray16_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray16_SByte Value
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

	unsafe static Str_103()
	{
		Value = InlineArrayHelper.Create<InlineArray16_SByte, byte>("/proc/self/auxv\0"u8);
		PointerIndices.Register(Pointer);
	}
}
