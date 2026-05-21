using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class OptionalStorage_char_false_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIPcE15OptionalStorageIS2_Lb0EEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<char*>::OptionalStorage<char*, false>::OptionalStorage()")]
	public unsafe static void Invoke(void* @this)
	{
		unchecked
		{
			*(sbyte*)(&((cpp_optional_char_OptionalStorage*)@this)->field) = 0;
			((cpp_optional_char_OptionalStorage*)@this)->in_use = 0;
		}
	}
}
