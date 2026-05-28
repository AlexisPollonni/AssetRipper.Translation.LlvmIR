using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_cpp_array_char_265ul_false_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS0_5arrayIcLm265EEEE15OptionalStorageIS3_Lb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::cpp::array<char, 265ul>>::OptionalStorage<__llvm_libc_20_1_2_::cpp::array<char, 265ul>, false>::OptionalStorage()")]
	public unsafe static void Invoke([MangledName("this")] Cpp_optional_cpp_array_char_265_OptionalStorage* This)
	{
		*unchecked((sbyte*)(&This->field)) = 0;
		This->In_use = 0;
	}
}
