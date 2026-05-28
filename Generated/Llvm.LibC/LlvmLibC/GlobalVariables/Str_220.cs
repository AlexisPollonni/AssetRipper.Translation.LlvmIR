using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.220")]
[DemangledName(".str.220")]
internal static partial class Str_220
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

	unsafe static Str_220()
	{
		Value = InlineArrayHelper.Create<InlineArray12_SByte, byte>("unsupported\0"u8);
		_ = Pointer;
	}
}
