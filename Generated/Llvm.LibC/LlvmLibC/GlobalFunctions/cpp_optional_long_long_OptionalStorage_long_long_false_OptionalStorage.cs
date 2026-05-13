using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxE15OptionalStorageIxLb0EEC2Ev")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::OptionalStorage<long long, false>::OptionalStorage()")]
internal static partial class cpp_optional_long_long_OptionalStorage_long_long_false_OptionalStorage
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
