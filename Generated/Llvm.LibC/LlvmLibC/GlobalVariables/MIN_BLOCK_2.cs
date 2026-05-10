using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZL11MIN_BLOCK_2")]
internal static partial class MIN_BLOCK_2
{
	[FixedAddressValueType]
	private static InlineArray69_SByte __value;

	public unsafe static InlineArray69_SByte* Pointer => unchecked((InlineArray69_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray69_SByte Value
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

	unsafe static MIN_BLOCK_2()
	{
		Value = InlineArrayHelper.Create<InlineArray69_SByte, byte>(new byte[69]
		{
			0, 0, 0, 0, 0, 0, 1, 1, 2, 3,
			3, 4, 4, 5, 5, 6, 6, 7, 7, 8,
			8, 9, 9, 10, 11, 11, 12, 12, 13, 13,
			14, 14, 15, 15, 16, 16, 17, 17, 18, 19,
			19, 20, 20, 21, 21, 22, 22, 23, 23, 24,
			24, 25, 26, 26, 27, 27, 28, 28, 29, 29,
			30, 30, 31, 31, 32, 32, 33, 34, 0
		});
		PointerIndices.Register(Pointer);
	}
}
