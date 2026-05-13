using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::internal::FPState")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPState")]
public partial struct fputil_internal_FPState
{
	[FieldOffset(0)]
	public fputil_internal_X87StateDescriptor x87_status;

	[FieldOffset(28)]
	public int mxcsr;
}
