using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_11printf_core13PaddingWriterE")]
[MangledName("class.__llvm_libc_20_1_2_::printf_core::PaddingWriter")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::PaddingWriter")]
public partial struct Llvm_libc_20_1_2_printf_core_PaddingWriter
{
	[FieldOffset(0)]
	public sbyte Left_justified;

	[FieldOffset(1)]
	public sbyte Leading_zeroes;

	[FieldOffset(2)]
	public sbyte Sign_char;

	[FieldOffset(8)]
	public long Min_width;
}
