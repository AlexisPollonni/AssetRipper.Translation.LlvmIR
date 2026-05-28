using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIeEEEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.16")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("Cpp_optional")]
public partial struct Cpp_optional_q5jaj8
{
	[FieldOffset(0)]
	public Cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage Storage;
}
