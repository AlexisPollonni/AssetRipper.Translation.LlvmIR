using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_int_false_OptionalStorage
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiE15OptionalStorageIiLb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::OptionalStorage<int, false>::OptionalStorage()")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			*(sbyte*)(&((Cpp_optional_int_OptionalStorage*)This)->field) = 0;
			((Cpp_optional_int_OptionalStorage*)This)->In_use = 0;
		}
	}
}
