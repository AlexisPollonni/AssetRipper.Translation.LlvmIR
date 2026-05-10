using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L18EXCEPT_OUTPUTS_SINE")]
[DemangledName("__llvm_libc_20_1_2_::EXCEPT_OUTPUTS_SIN")]
internal static partial class EXCEPT_OUTPUTS_SIN
{
	[FixedAddressValueType]
	private static InlineArray6_InlineArray4_Int32 __value;

	public unsafe static InlineArray6_InlineArray4_Int32* Pointer => unchecked((InlineArray6_InlineArray4_Int32*)Unsafe.AsPointer(ref __value));

	public static InlineArray6_InlineArray4_Int32 Value
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

	unsafe static EXCEPT_OUTPUTS_SIN()
	{
		Value = new InlineArrayBuilder<InlineArray6_InlineArray4_Int32, InlineArray4_Int32>
		{
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { -1095632291, 0, 1, 0 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { -1089004833, 0, 1, 1 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { -1084721887, 0, 1, 1 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { 1034772726, 1, 0, 1 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { -1099120160, 0, 1, 1 }),
			InlineArrayHelper.Create<InlineArray4_Int32, int>(new int[4] { -1084719845, 0, 1, 1 })
		};
		PointerIndices.Register(Pointer);
	}
}
