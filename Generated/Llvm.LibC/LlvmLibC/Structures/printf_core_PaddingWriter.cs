using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("class.__llvm_libc_20_1_2_::printf_core::PaddingWriter")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter")]
public partial struct printf_core_PaddingWriter
{
	[FieldOffset(0)]
	public sbyte left_justified;

	[FieldOffset(1)]
	public sbyte leading_zeroes;

	[FieldOffset(2)]
	public sbyte sign_char;

	[FieldOffset(8)]
	public long min_width;
}
