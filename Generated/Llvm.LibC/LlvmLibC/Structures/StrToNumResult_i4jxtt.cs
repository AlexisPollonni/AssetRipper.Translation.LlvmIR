using System;
using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14StrToNumResultIgEE")]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.0")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_i4jxtt
{
	[FieldOffset(0)]
	public Int128 Value;

	[FieldOffset(16)]
	public int Error;

	[FieldOffset(24)]
	public long Parsed_len;
}
