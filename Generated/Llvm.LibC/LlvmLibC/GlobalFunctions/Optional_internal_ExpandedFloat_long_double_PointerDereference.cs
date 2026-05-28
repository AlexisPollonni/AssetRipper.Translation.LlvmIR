using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Optional_internal_ExpandedFloat_long_double_PointerDereference
{
	[MangledName("_ZN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEEptEv")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::optional<__llvm_libc_20_1_2_::internal::ExpandedFloat<long double>>::operator->()")]
	public unsafe static Internal_ExpandedFloat_9jummq* Invoke([MangledName("this")] Cpp_optional_q5jaj8* This)
	{
		return unchecked((Internal_ExpandedFloat_9jummq*)(&This->Storage.field));
	}
}
