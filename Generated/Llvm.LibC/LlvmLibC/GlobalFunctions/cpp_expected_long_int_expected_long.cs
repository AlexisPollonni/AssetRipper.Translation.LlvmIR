using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIliEC2El")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<long, int>::expected(long)")]
internal static partial class cpp_expected_long_int_expected_long
{
	public unsafe static void Invoke(void* @this, long exp)
	{
		unchecked
		{
			*(long*)(&((cpp_expected*)@this)->field) = exp;
			((cpp_expected*)@this)->in_use = 1;
		}
	}
}
