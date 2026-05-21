using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_long_int_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::value()")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Llvm_libc_20_1_2_cpp_expected*)This)->field;
	}
}
