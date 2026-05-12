using LlvmLibC.Helpers;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZN19__llvm_libc_20_1_2_6fputil8internal26write_x87_state_descriptorERKNS1_18X87StateDescriptorE")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::write_x87_state_descriptor(__llvm_libc_20_1_2_::fputil::internal::X87StateDescriptor const&)")]
internal static partial class fputil_internal_write_x87_state_descriptor_fputil_internal_X87StateDescriptor_const
{
	public unsafe static void Invoke(fputil_internal_X87StateDescriptor* s)
	{
		AssemblyFunctions.M2(s);
	}
}
