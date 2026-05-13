using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("class.__llvm_libc_20_1_2_::details::StringBufferWriterImpl")]
[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl")]
public partial struct details_StringBufferWriterImpl
{
	[FieldOffset(0)]
	public cpp_string_view buffer;

	[FieldOffset(16)]
	public long index;

	[FieldOffset(24)]
	public sbyte out_of_range;

	[FieldOffset(25)]
	public InlineArray7_SByte field_3;
}
