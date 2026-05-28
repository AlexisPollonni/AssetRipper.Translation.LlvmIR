using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_7details22StringBufferWriterImplILb0EEE")]
[MangledName("class.__llvm_libc_20_1_2_::details::StringBufferWriterImpl")]
[DemangledName("__llvm_libc_20_1_2_::details::StringBufferWriterImpl")]
public partial struct Details_StringBufferWriterImpl
{
	[FieldOffset(0)]
	public Cpp_string_view Buffer;

	[FieldOffset(16)]
	public long Index;

	[FieldOffset(24)]
	public sbyte Out_of_range;

	[FieldOffset(25)]
	public InlineArray7_SByte field_3;
}
