using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPvEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<void*>::optional()")]
internal static partial class cpp_optional_void_optional
{
	public unsafe static void Invoke(void* @this)
	{
		cpp_optional_void_OptionalStorage_void_false_OptionalStorage.Invoke(&unchecked((cpp_optional_e5s7qx*)@this)->storage);
	}
}
