using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_float_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalIfE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<float>::value() &")]
	public unsafe static void* Invoke([MangledName("this")] Llvm_libc_20_1_2_cpp_optional_xmxtsi* This)
	{
		return &This->Storage.field;
	}
}
