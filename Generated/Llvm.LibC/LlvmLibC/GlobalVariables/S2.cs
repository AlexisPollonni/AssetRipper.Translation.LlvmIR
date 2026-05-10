using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_2S2E")]
[DemangledName("__llvm_libc_20_1_2_::S2")]
internal static partial class S2
{
	[FixedAddressValueType]
	private static InlineArray193_Int32 __value;

	public unsafe static InlineArray193_Int32* Pointer => unchecked((InlineArray193_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray193_Int32 Value
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

	unsafe static S2()
	{
		Value = InlineArrayHelper.Create<InlineArray193_Int32, int>(new int[193]
		{
			257, 253, 249, 245, 241, 237, 233, 229, 225, 221,
			217, 213, 209, 205, 201, 197, 193, 189, 185, 180,
			176, 172, 168, 164, 160, 156, 152, 148, 144, 140,
			136, 132, 128, 124, 120, 116, 112, 108, 104, 100,
			96, 92, 88, 84, 80, 76, 72, 68, 64, 60,
			56, 52, 48, 44, 40, 36, 32, 28, 24, 20,
			16, 12, 8, 4, 0, -4, -8, -12, -16, -20,
			-24, -28, -32, -36, -40, -44, -48, -52, -56, -60,
			-64, -68, -72, -76, -80, -84, -88, -92, -96, -100,
			-104, -108, -112, -116, -120, -124, -128, -132, -136, -140,
			-144, -148, -152, -156, -160, -164, -168, -172, -176, -180,
			-183, -187, -191, -195, -199, -203, -207, -211, -215, -219,
			-223, -227, -231, -235, -239, -243, -247, -251, -255, -259,
			-263, -267, -271, -275, -279, -283, -287, -291, -295, -299,
			-303, -307, -311, -314, -318, -322, -326, -330, -334, -338,
			-342, -346, -350, -354, -358, -362, -366, -370, -374, -378,
			-382, -386, -390, -394, -398, -402, -405, -409, -413, -417,
			-421, -425, -429, -433, -437, -441, -445, -449, -453, -457,
			-461, -465, -469, -473, -477, -480, -484, -488, -492, -496,
			-500, -504, -508
		});
		PointerIndices.Register(Pointer);
	}
}
