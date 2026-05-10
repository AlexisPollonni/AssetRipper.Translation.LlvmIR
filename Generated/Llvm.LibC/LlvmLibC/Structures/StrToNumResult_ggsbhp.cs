using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.12")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_ggsbhp
{
	[FieldOffset(0)]
	public internal_ExpandedFloat_9jummq value;

	[FieldOffset(32)]
	public int error;

	[FieldOffset(40)]
	public long parsed_len;
}
