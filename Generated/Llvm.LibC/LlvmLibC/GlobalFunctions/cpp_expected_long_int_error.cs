using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliE5errorEv")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::error()")]
internal static partial class cpp_expected_long_int_error
{
	public unsafe static void* Invoke(void* @this)
	{
		return &unchecked((cpp_expected*)@this)->field;
	}
}
