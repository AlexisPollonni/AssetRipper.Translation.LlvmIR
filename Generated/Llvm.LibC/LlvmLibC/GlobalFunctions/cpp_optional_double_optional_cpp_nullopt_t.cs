using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIdEC2ENS0_9nullopt_tE")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::optional(__llvm_libc_20_1_2_::cpp::nullopt_t)")]
internal static partial class cpp_optional_double_optional_cpp_nullopt_t
{
	public unsafe static void Invoke(cpp_optional_s4iqgj* @this)
	{
		cpp_optional_double_OptionalStorage_double_false_OptionalStorage.Invoke(&@this->storage);
	}
}
