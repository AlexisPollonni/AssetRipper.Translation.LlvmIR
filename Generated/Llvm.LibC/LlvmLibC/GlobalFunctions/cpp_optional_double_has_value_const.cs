using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIdE9has_valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<double>::has_value() const")]
internal static partial class cpp_optional_double_has_value_const
{
	public unsafe static bool Invoke(cpp_optional_s4iqgj* @this)
	{
		return (@this->storage.in_use & 1) == 1;
	}
}
