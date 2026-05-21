using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.61")]
[DemangledName(".str.61")]
internal static partial class Str_61
{
	[FixedAddressValueType]
	private static InlineArray43_SByte __value;

	public unsafe static InlineArray43_SByte* Pointer => unchecked((InlineArray43_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray43_SByte Value
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

	unsafe static Str_61()
	{
		Value = InlineArrayHelper.Create<InlineArray43_SByte, byte>("173472347597680709441192448139190673828125\0"u8);
		PointerIndices.Register(Pointer);
	}
}
