using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_double_false_OptionalStorage
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdE15OptionalStorageIdLb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::OptionalStorage<double, false>::OptionalStorage()")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_double_OptionalStorage* This)
	{
		*unchecked((sbyte*)(&This->field)) = 0;
		This->In_use = 0;
	}
}
