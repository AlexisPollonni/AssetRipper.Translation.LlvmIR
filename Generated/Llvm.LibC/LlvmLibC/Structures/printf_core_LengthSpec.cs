using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__llvm_libc_20_1_2_::printf_core::LengthSpec")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::LengthSpec")]
public partial struct printf_core_LengthSpec
{
	[FieldOffset(0)]
	public int lm;

	[FieldOffset(8)]
	public long bit_width;
}
