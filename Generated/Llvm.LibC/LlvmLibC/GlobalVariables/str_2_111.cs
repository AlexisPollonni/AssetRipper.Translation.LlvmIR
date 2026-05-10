using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName(".str.2.111")]
[DemangledName(".str.2.111")]
internal static partial class str_2_111
{
	[FixedAddressValueType]
	private static InlineArray10_SByte __value;

	public unsafe static InlineArray10_SByte* Pointer => unchecked((InlineArray10_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray10_SByte Value
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

	unsafe static str_2_111()
	{
		Value = InlineArrayHelper.Create<InlineArray10_SByte, byte>("/dev/shm/\0"u8);
		PointerIndices.Register(Pointer);
	}
}
