using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIfE15OptionalStorageIfLb0EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::OptionalStorage<float, false>::OptionalStorage()")]
internal static partial class cpp_optional_float_OptionalStorage_float_false_OptionalStorage
{
	public unsafe static void Invoke(cpp_optional_float_OptionalStorage* @this)
	{
		*unchecked((sbyte*)(&@this->field)) = 0;
		@this->in_use = 0;
	}
}
