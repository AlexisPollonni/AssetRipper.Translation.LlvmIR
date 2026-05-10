using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_11fixed_point8internal10SqrtConfigIDRtE12FIRST_APPROXE")]
[DemangledName("__llvm_libc_20_1_2_::fixed_point::internal::SqrtConfig<unsigned short _Fract>::FIRST_APPROX")]
internal static partial class fixed_point_internal_SqrtConfig_unsigned_short_Fract_FIRST_APPROX
{
	[FixedAddressValueType]
	private static InlineArray12_InlineArray2_SByte __value;

	public unsafe static InlineArray12_InlineArray2_SByte* Pointer => unchecked((InlineArray12_InlineArray2_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray12_InlineArray2_SByte Value
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

	unsafe static fixed_point_internal_SqrtConfig_unsigned_short_Fract_FIRST_APPROX()
	{
		Value = new InlineArrayBuilder<InlineArray12_InlineArray2_SByte, InlineArray2_SByte>
		{
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 244, 67 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 221, 74 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 202, 81 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 186, 88 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 176, 93 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 167, 98 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 159, 103 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 153, 107 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 145, 113 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 140, 117 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 132, 124 }),
			InlineArrayHelper.Create<InlineArray2_SByte, byte>(new byte[2] { 130, 126 })
		};
		PointerIndices.Register(Pointer);
	}
}
