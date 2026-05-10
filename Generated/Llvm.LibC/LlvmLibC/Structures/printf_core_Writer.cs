using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("class.__llvm_libc_20_1_2_::printf_core::Writer")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::Writer")]
public partial struct printf_core_Writer
{
	[FieldOffset(0)]
	public unsafe void* wb;

	[FieldOffset(8)]
	public int chars_written;

	[FieldOffset(12)]
	public InlineArray4_SByte field_2;
}
