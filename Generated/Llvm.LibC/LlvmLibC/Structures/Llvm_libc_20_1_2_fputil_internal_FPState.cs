using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_6fputil8internal7FPStateE")]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::internal::FPState")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPState")]
public partial struct Llvm_libc_20_1_2_fputil_internal_FPState
{
	[FieldOffset(0)]
	public Llvm_libc_20_1_2_fputil_internal_X87StateDescriptor X87_status;

	[FieldOffset(28)]
	public int Mxcsr;
}
