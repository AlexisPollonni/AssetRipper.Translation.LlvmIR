using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("class.__llvm_libc_20_1_2_::cpp::string_view")]
[DemangledName("__llvm_libc_20_1_2_::cpp::string_view")]
public partial struct cpp_string_view
{
	[FieldOffset(0)]
	public unsafe void* span_data;

	[FieldOffset(8)]
	public long span_size;
}
