using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("struct.__llvm_libc_20_1_2_::internal::ExpandedFloat.27")]
[DemangledName("__llvm_libc_20_1_2_::internal::ExpandedFloat")]
[CleanName("internal_ExpandedFloat")]
public partial struct internal_ExpandedFloat_i7t5up
{
	[FieldOffset(0)]
	public int mantissa;

	[FieldOffset(4)]
	public int exponent;
}
