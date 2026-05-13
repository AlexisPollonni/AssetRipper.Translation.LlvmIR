using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZL12POW10_OFFSET")]
internal static partial class POW10_OFFSET
{
	[FixedAddressValueType]
	private static InlineArray64_Int16 __value;

	public unsafe static InlineArray64_Int16* Pointer => unchecked((InlineArray64_Int16*)Unsafe.AsPointer(ref __value));

	public static InlineArray64_Int16 Value
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

	unsafe static POW10_OFFSET()
	{
		Value = InlineArrayHelper.Create<InlineArray64_Int16, short>(new short[64]
		{
			0, 2, 5, 8, 12, 16, 21, 26, 32, 39,
			46, 54, 62, 71, 80, 90, 100, 111, 122, 134,
			146, 159, 173, 187, 202, 217, 233, 249, 266, 283,
			301, 319, 338, 357, 377, 397, 418, 440, 462, 485,
			508, 532, 556, 581, 606, 632, 658, 685, 712, 740,
			769, 798, 828, 858, 889, 920, 952, 984, 1017, 1050,
			1084, 1118, 1153, 1188
		});
		PointerIndices.Register(Pointer);
	}
}
