using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_get_x87_state_descriptor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal24get_x87_state_descriptorERNS1_18X87StateDescriptorE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::get_x87_state_descriptor(__llvm_libc_20_1_2_::fputil::internal::X87StateDescriptor&)")]
	public unsafe static void Invoke([MangledName("s")][NativeType("__llvm_libc_20_1_2_::fputil::internal::X87StateDescriptor&")] Fputil_internal_X87StateDescriptor* S)
	{
		IntrinsicFunctions.AsmFnstenv(S);
	}
}
