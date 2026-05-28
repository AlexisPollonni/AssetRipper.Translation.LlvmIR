using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp8optionalINS_8internal13ExpandedFloatIfEEEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::optional.29")]
[DemangledName("__llvm_libc_20_1_2_::cpp::optional")]
[CleanName("Cpp_optional")]
public partial struct Cpp_optional_6hseum
{
	[FieldOffset(0)]
	public Cpp_optional_internal_ExpandedFloat_float_OptionalStorage Storage;
}
