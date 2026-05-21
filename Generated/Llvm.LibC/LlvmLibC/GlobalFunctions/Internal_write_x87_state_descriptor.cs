using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_write_x87_state_descriptor
{
	[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal26write_x87_state_descriptorERKNS1_18X87StateDescriptorE")]
	[DemangledName("__llvm_libc_20_1_2_::fputil::internal::write_x87_state_descriptor(__llvm_libc_20_1_2_::fputil::internal::X87StateDescriptor const&)")]
	public unsafe static void Invoke([MangledName("s")][NativeType("__llvm_libc_20_1_2_::fputil::internal::X87StateDescriptor const&")] Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor* S)
	{
		IntrinsicFunctions.AsmFldenv(S);
	}
}
