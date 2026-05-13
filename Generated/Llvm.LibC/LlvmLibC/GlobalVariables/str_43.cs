using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.43")]
[DemangledName(".str.43")]
internal static partial class str_43
{
	[FixedAddressValueType]
	private static InlineArray30_SByte __value;

	public unsafe static InlineArray30_SByte* Pointer => unchecked((InlineArray30_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray30_SByte Value
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

	unsafe static str_43()
	{
		Value = InlineArrayHelper.Create<InlineArray30_SByte, byte>("45474735088646411895751953125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
