using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIfE5valueEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::value() &")]
internal static partial class cpp_optional_float_value
{
	public unsafe static void* Invoke(cpp_optional_89h55j* @this)
	{
		return &@this->storage.field;
	}
}
