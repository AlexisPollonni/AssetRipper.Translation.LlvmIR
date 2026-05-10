using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalImE15OptionalStorageImLb0EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned long>::OptionalStorage<unsigned long, false>::OptionalStorage()")]
internal static partial class cpp_optional_unsigned_long_OptionalStorage_unsigned_long_false_OptionalStorage
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(sbyte*)(&((cpp_expected*)@this)->field) = 0;
			((cpp_expected*)@this)->in_use = 0;
		}
	}
}
