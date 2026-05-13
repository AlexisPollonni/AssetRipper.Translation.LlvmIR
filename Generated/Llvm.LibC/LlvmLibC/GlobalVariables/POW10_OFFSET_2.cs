using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZL14POW10_OFFSET_2")]
internal static partial class POW10_OFFSET_2
{
	[FixedAddressValueType]
	private static InlineArray69_Int16 __value;

	public unsafe static InlineArray69_Int16* Pointer => unchecked((InlineArray69_Int16*)Unsafe.AsPointer(ref __value));

	public static InlineArray69_Int16 Value
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

	unsafe static POW10_OFFSET_2()
	{
		Value = InlineArrayHelper.Create<InlineArray69_Int16, short>(new short[69]
		{
			0, 2, 6, 12, 20, 29, 40, 52, 66, 80,
			95, 112, 130, 150, 170, 192, 215, 240, 265, 292,
			320, 350, 381, 413, 446, 480, 516, 552, 590, 629,
			670, 712, 755, 799, 845, 892, 940, 989, 1040, 1092,
			1145, 1199, 1254, 1311, 1369, 1428, 1488, 1550, 1613, 1678,
			1743, 1810, 1878, 1947, 2017, 2088, 2161, 2235, 2311, 2387,
			2465, 2544, 2625, 2706, 2789, 2873, 2959, 3046, 3133
		});
		PointerIndices.Register(Pointer);
	}
}
