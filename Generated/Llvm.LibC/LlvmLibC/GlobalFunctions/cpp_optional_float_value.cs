using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIfE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::value() &")]
internal static partial class cpp_optional_float_value
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_optional_89h55j*)@this)->storage.field;
	}
}
