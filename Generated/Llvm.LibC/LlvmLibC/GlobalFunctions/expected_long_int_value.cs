using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class expected_long_int_value
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::value()")]
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_expected*)@this)->field;
	}
}
