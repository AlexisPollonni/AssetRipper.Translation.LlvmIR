using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8expectedIiiEC2Ei")]
[DemangledName("__llvm_libc_20_1_2_::cpp::expected<int, int>::expected(int)")]
internal static partial class cpp_expected_int_int_expected_int
{
	public unsafe static void Invoke(void* @this, int exp)
	{
		unchecked
		{
			*(int*)(&((cpp_optional_int_OptionalStorage*)@this)->field) = exp;
			((cpp_optional_int_OptionalStorage*)@this)->in_use = 1;
		}
	}
}
