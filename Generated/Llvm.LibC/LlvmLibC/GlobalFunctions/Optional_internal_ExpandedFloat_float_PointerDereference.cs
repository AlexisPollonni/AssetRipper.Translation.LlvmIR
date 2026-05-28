using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_float_PointerDereference
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEEptEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<float>>::operator->()")]
	public unsafe static Internal_ExpandedFloat_i7t5up* Invoke([MangledName("this")] Cpp_optional_6hseum* This)
	{
		return unchecked((Internal_ExpandedFloat_i7t5up*)(&This->Storage.field));
	}
}
