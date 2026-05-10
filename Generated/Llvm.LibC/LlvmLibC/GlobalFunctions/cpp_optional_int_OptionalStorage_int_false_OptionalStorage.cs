using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIiE15OptionalStorageIiLb0EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::OptionalStorage<int, false>::OptionalStorage()")]
internal static partial class cpp_optional_int_OptionalStorage_int_false_OptionalStorage
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(sbyte*)(&((cpp_optional_int_OptionalStorage*)@this)->field) = 0;
			((cpp_optional_int_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
