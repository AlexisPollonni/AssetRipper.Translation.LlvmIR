using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Expected_long_int_error
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliE5errorEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::error()")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Cpp_expected*)This)->field;
	}
}
