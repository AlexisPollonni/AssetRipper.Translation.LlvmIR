using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_long_double_false_OptionalStorage
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeE15OptionalStorageIeLb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::OptionalStorage<long double, false>::OptionalStorage()")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		unchecked
		{
			*(sbyte*)(&((Cpp_optional_long_double_OptionalStorage*)This)->field) = 0;
			((Cpp_optional_long_double_OptionalStorage*)This)->field_1 = 0;
		}
	}
}
