using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.62")]
[DemangledName(".str.62")]
internal static partial class Str_62
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

	unsafe static Str_62()
	{
		Value = InlineArrayHelper.Create<InlineArray43_SByte, byte>("867361737988403547205962240695953369140625\0"u8);
		_ = Pointer;
	}
}
