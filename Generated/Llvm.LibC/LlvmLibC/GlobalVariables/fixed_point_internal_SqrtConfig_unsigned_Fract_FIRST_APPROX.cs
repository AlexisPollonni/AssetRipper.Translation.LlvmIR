using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point8internal10SqrtConfigIDRjE12FIRST_APPROXE")]
[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned _Fract>::FIRST_APPROX")]
internal static partial class fixed_point_internal_SqrtConfig_unsigned_Fract_FIRST_APPROX
{
	[FixedAddressValueType]
	private static InlineArray12_InlineArray2_Int16 __value;

	public unsafe static InlineArray12_InlineArray2_Int16* Pointer => unchecked((InlineArray12_InlineArray2_Int16*)Unsafe.AsPointer(ref __value));

	public static InlineArray12_InlineArray2_Int16 Value
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

	unsafe static fixed_point_internal_SqrtConfig_unsigned_Fract_FIRST_APPROX()
	{
		Value = new InlineArrayBuilder<InlineArray12_InlineArray2_Int16, InlineArray2_Int16>
		{
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -3652, 17324 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -9591, 19173 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -14088, 20855 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -17647, 22409 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -20563, 23865 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -22996, 25232 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -25073, 26529 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -26874, 27766 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -28459, 28954 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -29859, 30091 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -31112, 31187 }),
			InlineArrayHelper.Create<InlineArray2_Int16, short>(new short[2] { -32312, 32312 })
		};
		PointerIndices.Register(Pointer);
	}
}
