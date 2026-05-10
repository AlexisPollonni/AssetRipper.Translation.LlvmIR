using System.Runtime.CompilerServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L13EXP2_MID_BITSE.11")]
[DemangledName("__llvm_libc_20_1_2_::EXP2_MID_BITS (.11)")]
internal static partial class EXP2_MID_BITS_11
{
	[FixedAddressValueType]
	private static cpp_array_vwpjic __value;

	public unsafe static cpp_array_vwpjic* Pointer => unchecked((cpp_array_vwpjic*)Unsafe.AsPointer(ref __value));

	public static cpp_array_vwpjic Value
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

	unsafe static EXP2_MID_BITS_11()
	{
		Value = new cpp_array_vwpjic
		{
			Data = InlineArrayHelper.Create<InlineArray8_Int32, int>(new int[8] { 1065353216, 1066112450, 1066940400, 1067843287, 1068827891, 1069901610, 1071072509, 1072349383 })
		};
		PointerIndices.Register(Pointer);
	}
}
