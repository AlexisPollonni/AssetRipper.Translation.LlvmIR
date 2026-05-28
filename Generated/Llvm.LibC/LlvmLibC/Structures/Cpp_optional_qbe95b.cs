using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 128)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalI6statfsEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.6038")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("Cpp_optional")]
public partial struct Cpp_optional_qbe95b
{
	[FieldOffset(0)]
	public Cpp_optional_statfs_OptionalStorage Storage;
}
