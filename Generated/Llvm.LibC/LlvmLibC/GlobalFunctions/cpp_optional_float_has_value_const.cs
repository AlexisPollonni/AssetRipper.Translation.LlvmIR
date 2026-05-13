using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIfE9has_valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::has_value() const")]
internal static partial class cpp_optional_float_has_value_const
{
	public unsafe static bool Invoke(cpp_optional_89h55j* @this)
	{
		return (@this->storage.in_use & 1) == 1;
	}
}
