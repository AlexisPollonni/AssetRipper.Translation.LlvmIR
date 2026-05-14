using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalIfEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.6014")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("cpp_optional")]
public partial struct cpp_optional_g66fk4
{
	[FieldOffset(0)]
	public cpp_optional_int_OptionalStorage storage;
}
