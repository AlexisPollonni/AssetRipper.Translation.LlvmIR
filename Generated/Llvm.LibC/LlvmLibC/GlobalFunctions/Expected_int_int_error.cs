using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_int_int_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIiiE5errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::error()")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Cpp_optional_int_OptionalStorage*)This)->field;
	}
}
