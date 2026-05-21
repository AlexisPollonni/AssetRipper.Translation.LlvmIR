using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point8internal10SqrtConfigIDRmE12FIRST_APPROXE")]
[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned long _Fract>::FIRST_APPROX")]
internal static partial class Llvm_libc_20_1_2_fixed_point_internal_SqrtConfig_unsigned_long_Fract_FIRST_APPROX
{
	[FixedAddressValueType]
	private static InlineArray12_InlineArray2_Int32 __value;

	public unsafe static InlineArray12_InlineArray2_Int32* Pointer => unchecked((InlineArray12_InlineArray2_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray12_InlineArray2_Int32 Value
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

	unsafe static Llvm_libc_20_1_2_fixed_point_internal_SqrtConfig_unsigned_long_Fract_FIRST_APPROX()
	{
		Value = new InlineArrayBuilder<InlineArray12_InlineArray2_Int32, InlineArray2_Int32>
		{
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -239350324, 1135345122 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -628409287, 1256465077 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -923219227, 1366728707 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -1156620710, 1468645395 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -1347367741, 1563878607 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -1507058321, 1653600243 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -1643303794, 1738673615 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -1761334739, 1819756877 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -1864880635, 1897365644 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -1956682111, 1971912900 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -2038804496, 2043735569 }),
			InlineArrayHelper.Create<InlineArray2_Int32, int>(new int[2] { -2117701664, 2117701664 })
		};
		PointerIndices.Register(Pointer);
	}
}
