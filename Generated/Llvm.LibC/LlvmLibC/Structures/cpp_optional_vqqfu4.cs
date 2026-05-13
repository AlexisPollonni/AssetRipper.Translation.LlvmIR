using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.6072")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("cpp_optional")]
public partial struct cpp_optional_vqqfu4
{
	[FieldOffset(0)]
	public cpp_optional_internal_ExpandedFloat_double_OptionalStorage storage;
}
