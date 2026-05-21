using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L15EXP2_MID_5_BITSE.12")]
[DemangledName("__llvm_libc_20_1_2_::EXP2_MID_5_BITS (.12)")]
internal static partial class Llvm_libc_20_1_2_EXP2_MID_5_BITS_12
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_cpp_array_xx2b9m __value;

	public unsafe static Llvm_libc_20_1_2_cpp_array_xx2b9m* Pointer => unchecked((Llvm_libc_20_1_2_cpp_array_xx2b9m*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_cpp_array_xx2b9m Value
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

	unsafe static Llvm_libc_20_1_2_EXP2_MID_5_BITS_12()
	{
		Value = new Llvm_libc_20_1_2_cpp_array_xx2b9m
		{
			Data = InlineArrayHelper.Create<InlineArray32_Int32, int>(new int[32]
			{
				1065353216, 1065536903, 1065724611, 1065916431, 1066112450, 1066312762, 1066517459, 1066726640, 1066940400, 1067158842,
				1067382066, 1067610179, 1067843287, 1068081499, 1068324927, 1068573686, 1068827891, 1069087663, 1069353124, 1069624397,
				1069901610, 1070184894, 1070474380, 1070770206, 1071072509, 1071381432, 1071697119, 1072019719, 1072349383, 1072686266,
				1073030525, 1073382323
			})
		};
		PointerIndices.Register(Pointer);
	}
}
