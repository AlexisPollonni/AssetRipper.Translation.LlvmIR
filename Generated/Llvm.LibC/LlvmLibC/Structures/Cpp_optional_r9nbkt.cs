using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal10AbsTimeoutEEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.6090")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("Cpp_optional")]
public partial struct Cpp_optional_r9nbkt
{
	[FieldOffset(0)]
	public Cpp_optional_internal_AbsTimeout_OptionalStorage Storage;
}
