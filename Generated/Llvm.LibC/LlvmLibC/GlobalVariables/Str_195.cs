using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.195")]
[DemangledName(".str.195")]
internal static partial class Str_195
{
	[FixedAddressValueType]
	private static InlineArray14_SByte __value;

	public unsafe static InlineArray14_SByte* Pointer => unchecked((InlineArray14_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray14_SByte Value
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

	unsafe static Str_195()
	{
		Value = InlineArrayHelper.Create<InlineArray14_SByte, byte>("Unknown error\0"u8);
		PointerIndices.Register(Pointer);
	}
}
