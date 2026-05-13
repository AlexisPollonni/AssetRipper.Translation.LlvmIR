using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.5956")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("cpp_optional")]
public partial struct cpp_optional_7xva92
{
	[FieldOffset(0)]
	public cpp_optional_internal_AbsTimeout_OptionalStorage storage;
}
