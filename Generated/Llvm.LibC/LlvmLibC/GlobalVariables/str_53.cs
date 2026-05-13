using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.53")]
[DemangledName(".str.53")]
internal static partial class str_53
{
	[FixedAddressValueType]
	private static InlineArray37_SByte __value;

	public unsafe static InlineArray37_SByte* Pointer => unchecked((InlineArray37_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray37_SByte Value
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

	unsafe static str_53()
	{
		Value = InlineArrayHelper.Create<InlineArray37_SByte, byte>("444089209850062616169452667236328125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
