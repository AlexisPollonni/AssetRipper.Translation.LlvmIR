using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class optional_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeEC2EOe")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::optional(long double&&)")]
	public unsafe static void Invoke(void* @this, [NativeType("long double&&")] void* t)
	{
		unchecked
		{
			OptionalStorage_long_double_false_OptionalStorage_long_double.Invoke(&((cpp_optional_59q3zq*)@this)->storage, cpp_move_long_double.Invoke(t));
			((cpp_optional_59q3zq*)@this)->storage.field_1 = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::optional()")]
	public unsafe static void Invoke(void* @this)
	{
		OptionalStorage_long_double_false_OptionalStorage.Invoke(&unchecked((cpp_optional_59q3zq*)@this)->storage);
	}
}
