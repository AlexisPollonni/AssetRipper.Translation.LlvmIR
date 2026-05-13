using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.__llvm_libc_20_1_2_::fputil::internal::FPStorage.3")]
[DemangledName("__llvm_libc_20_1_2_::fputil::internal::FPStorage")]
[CleanName("fputil_internal_FPStorage")]
public partial struct fputil_internal_FPStorage_v3nexn
{
	[FieldOffset(0)]
	public long val;
}
