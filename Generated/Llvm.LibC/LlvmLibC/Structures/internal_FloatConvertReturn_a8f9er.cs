using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 12)]
[MangledName("struct.__llvm_libc_20_1_2_::internal::FloatConvertReturn.28")]
[DemangledName("__llvm_libc_20_1_2_::internal::FloatConvertReturn")]
[CleanName("internal_FloatConvertReturn")]
public partial struct internal_FloatConvertReturn_a8f9er
{
	[FieldOffset(0)]
	public internal_ExpandedFloat_i7t5up num;

	[FieldOffset(8)]
	public int error;
}
