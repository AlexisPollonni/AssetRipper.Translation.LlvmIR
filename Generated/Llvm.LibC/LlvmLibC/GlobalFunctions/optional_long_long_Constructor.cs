using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_long_long_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxEC2EOx")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::optional(long long&&)")]
	public unsafe static void Invoke(void* @this, [NativeType("long long&&")] void* t)
	{
		unchecked
		{
			OptionalStorage_long_long_false_OptionalStorage_long_long.Invoke(&((cpp_optional_d6hvji*)@this)->storage, cpp_move_long_long.Invoke(t));
			((cpp_optional_d6hvji*)@this)->storage.in_use = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIxEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long long>::optional()")]
	public unsafe static void Invoke(void* @this)
	{
		OptionalStorage_long_long_false_OptionalStorage.Invoke(&unchecked((cpp_optional_d6hvji*)@this)->storage);
	}
}
