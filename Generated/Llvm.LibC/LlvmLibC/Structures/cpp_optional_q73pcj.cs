using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.6435")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("cpp_optional")]
public partial struct cpp_optional_q73pcj
{
	[FieldOffset(0)]
	public cpp_optional_cpp_string_view_OptionalStorage storage;
}
