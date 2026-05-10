using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.0")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("cpp_optional")]
public partial struct cpp_optional_d6hvji
{
	[FieldOffset(0)]
	public cpp_expected storage;
}
