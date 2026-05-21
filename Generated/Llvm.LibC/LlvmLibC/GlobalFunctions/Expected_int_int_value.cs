using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_int_int_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIiiE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::value()")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Llvm_libc_20_1_2_cpp_optional_int_OptionalStorage*)This)->field;
	}
}
