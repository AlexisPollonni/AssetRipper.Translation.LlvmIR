using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_long_double_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIeE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<long double>::value() &")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Llvm_libc_20_1_2_cpp_optional_59q3zq*)This)->Storage.field;
	}
}
