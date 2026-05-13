using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.16")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("cpp_optional")]
public partial struct cpp_optional_q5jaj8
{
	[FieldOffset(0)]
	public cpp_optional_internal_ExpandedFloat_long_double_OptionalStorage storage;
}
