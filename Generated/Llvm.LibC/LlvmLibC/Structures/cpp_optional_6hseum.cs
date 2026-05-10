using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.29")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("cpp_optional")]
public partial struct cpp_optional_6hseum
{
	[FieldOffset(0)]
	public cpp_optional_internal_ExpandedFloat_float_OptionalStorage storage;
}
