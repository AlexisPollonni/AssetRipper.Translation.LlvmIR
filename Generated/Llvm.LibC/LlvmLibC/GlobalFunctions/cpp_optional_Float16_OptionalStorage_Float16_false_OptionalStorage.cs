using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIDF16_E15OptionalStorageIDF16_Lb0EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<_Float16>::OptionalStorage<_Float16, false>::OptionalStorage()")]
internal static partial class cpp_optional_Float16_OptionalStorage_Float16_false_OptionalStorage
{
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(sbyte*)(&((cpp_optional_Float16_OptionalStorage*)@this)->field) = 0;
			((cpp_optional_Float16_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
