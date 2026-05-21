using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_long_double_has_value
{
	[MangledName("_ZNK19__llvm_libc_20_1_2_3cpp8optionalIeE9has_valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::has_value() const")]
	public unsafe static bool Invoke([MangledName("this")] void* This)
	{
		return (unchecked((Llvm_libc_20_1_2_cpp_optional_59q3zq*)This)->Storage.field_1 & 1) == 1;
	}
}
