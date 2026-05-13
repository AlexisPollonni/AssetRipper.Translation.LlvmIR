using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.1.164")]
[DemangledName(".str.1.164")]
internal static partial class str_1_164
{
	[FixedAddressValueType]
	private static InlineArray4_SByte __value;

	public unsafe static InlineArray4_SByte* Pointer => unchecked((InlineArray4_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray4_SByte Value
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

	unsafe static str_1_164()
	{
		Value = InlineArrayHelper.Create<InlineArray4_SByte, byte>("INF\0"u8);
		PointerIndices.Register(Pointer);
	}
}
