using System;
using System.Runtime.InteropServices;
using LlvmLibC.Helpers;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.0")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_i4jxtt
{
	[FieldOffset(0)]
	public Int128 value;

	[FieldOffset(16)]
	public int error;

	[FieldOffset(24)]
	public long parsed_len;
}
