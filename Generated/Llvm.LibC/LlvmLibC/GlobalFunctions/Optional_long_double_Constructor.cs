using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_long_double_Constructor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeEC2EOe")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::optional(long double&&)")]
	public unsafe static void Invoke([MangledName("this")] void* This, [MangledName("t")][NativeType("long double&&")] void* T)
	{
		unchecked
		{
			OptionalStorage_long_double_false_OptionalStorage_long_double.Invoke(&((Cpp_optional_59q3zq*)This)->Storage, Cpp_move_long_double.Invoke(T));
			((Cpp_optional_59q3zq*)This)->Storage.field_1 = 1;
		}
	}

	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalIeEC2Ev")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::optional()")]
	public unsafe static void Invoke([MangledName("this")] void* This)
	{
		OptionalStorage_long_double_false_OptionalStorage.Invoke(&unchecked((Cpp_optional_59q3zq*)This)->Storage);
	}
}
