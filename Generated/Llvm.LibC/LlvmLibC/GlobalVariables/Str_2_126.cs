using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.2.126")]
[DemangledName(".str.2.126")]
internal static partial class Str_2_126
{
	[FixedAddressValueType]
	private static InlineArray1_SByte __value;

	public unsafe static InlineArray1_SByte* Pointer => unchecked((InlineArray1_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray1_SByte Value
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

	unsafe static Str_2_126()
	{
		PointerIndices.Register(Pointer);
	}
}
