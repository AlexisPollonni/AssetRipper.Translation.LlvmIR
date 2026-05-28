using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_float_value
{
	[MangledName("_ZNR19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEE5valueEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::value() &")]
	public unsafe static Internal_ExpandedFloat_i7t5up* Invoke([MangledName("this")] Cpp_optional_6hseum* This)
	{
		return unchecked((Internal_ExpandedFloat_i7t5up*)(&This->Storage.field));
	}
}
