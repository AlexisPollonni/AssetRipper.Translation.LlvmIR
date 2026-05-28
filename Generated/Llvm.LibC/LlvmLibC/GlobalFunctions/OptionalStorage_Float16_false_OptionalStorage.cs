using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_Float16_false_OptionalStorage
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_E15OptionalStorageIDF16_Lb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::OptionalStorage<_Float16, false>::OptionalStorage()")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")] Cpp_optional_Float16_OptionalStorage* This)
	{
		*unchecked((sbyte*)(&This->field)) = 0;
		This->In_use = 0;
	}
}
