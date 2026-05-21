using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_unsigned_int_false_OptionalStorage
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIjE15OptionalStorageIjLb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<unsigned int>::OptionalStorage<unsigned int, false>::OptionalStorage()")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::optional")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(sbyte*)(&((cpp_optional_int_OptionalStorage*)@this)->field) = 0;
			((cpp_optional_int_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
