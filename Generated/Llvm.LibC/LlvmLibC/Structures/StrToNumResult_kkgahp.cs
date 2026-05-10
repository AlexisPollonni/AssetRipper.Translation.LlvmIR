using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.26")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_kkgahp
{
	[FieldOffset(0)]
	public internal_ExpandedFloat_i7t5up value;

	[FieldOffset(8)]
	public int error;

	[FieldOffset(16)]
	public long parsed_len;
}
