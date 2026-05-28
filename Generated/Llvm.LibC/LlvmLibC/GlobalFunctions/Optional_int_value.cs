using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_int_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIiE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<int>::value() &")]
	public unsafe static void* Invoke([MangledName("this")] void* This)
	{
		return &unchecked((Cpp_optional_g66fk4*)This)->Storage.field;
	}
}
