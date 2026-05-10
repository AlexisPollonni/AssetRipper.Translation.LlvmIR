using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_17EXP_MIDE.2")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::EXP_MID (.2)")]
internal static partial class anonymous_namespace_EXP_MID_2
{
	[FixedAddressValueType]
	private static InlineArray8_Int16 __value;

	public unsafe static InlineArray8_Int16* Pointer => unchecked((InlineArray8_Int16*)Unsafe.AsPointer(ref __value));

	public static InlineArray8_Int16 Value
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

	unsafe static anonymous_namespace_EXP_MID_2()
	{
		Value = InlineArrayHelper.Create<InlineArray8_Int16, short>(new short[8] { 78, 88, 100, 113, 128, 145, 164, 186 });
		PointerIndices.Register(Pointer);
	}
}
