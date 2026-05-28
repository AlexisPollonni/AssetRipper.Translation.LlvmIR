using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_3cpp4spanIcEE")]
[MangledName("class.__llvm_libc_20_1_2_::cpp::string_view")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view")]
public partial struct Cpp_string_view
{
	[FieldOffset(0)]
	public unsafe void* Span_data;

	[FieldOffset(8)]
	public long Span_size;
}
