using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::value()")]
internal static partial class cpp_expected_long_int_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_expected*)@this)->field;
	}
}
