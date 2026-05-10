using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.3421")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_jptppf
{
	[FieldOffset(0)]
	public float value;

	[FieldOffset(4)]
	public int error;

	[FieldOffset(8)]
	public long parsed_len;
}
