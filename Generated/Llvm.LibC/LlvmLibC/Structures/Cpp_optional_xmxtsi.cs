using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalIfEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.2780")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("Cpp_optional")]
public partial struct Cpp_optional_xmxtsi
{
	[FieldOffset(0)]
	public Cpp_optional_float_OptionalStorage Storage;
}
