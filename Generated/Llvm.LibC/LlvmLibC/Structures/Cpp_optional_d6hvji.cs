using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalIdEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.0")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("Cpp_optional")]
public partial struct Cpp_optional_d6hvji
{
	[FieldOffset(0)]
	public Cpp_expected Storage;
}
