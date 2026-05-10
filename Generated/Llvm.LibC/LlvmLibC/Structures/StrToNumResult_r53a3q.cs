using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.3434")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_r53a3q
{
	[FieldOffset(0)]
	public double value;

	[FieldOffset(8)]
	public int error;

	[FieldOffset(16)]
	public long parsed_len;
}
