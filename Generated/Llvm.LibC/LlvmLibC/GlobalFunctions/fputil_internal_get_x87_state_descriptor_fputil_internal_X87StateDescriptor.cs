using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal24get_x87_state_descriptorERNS1_18X87StateDescriptorE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::get_x87_state_descriptor(__llvm_libc_20_1_2_::fputil::internal::X87StateDescriptor&)")]
internal static partial class fputil_internal_get_x87_state_descriptor_fputil_internal_X87StateDescriptor
{
	public unsafe static void Invoke(fputil_internal_X87StateDescriptor* s)
	{
		IntrinsicFunctions.AsmFnstenv(s);
	}
}
