using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14StrToNumResultIDF16_EE")]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.3490")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_cqc3yy
{
	[FieldOffset(0)]
	public float Value;

	[FieldOffset(4)]
	public int Error;

	[FieldOffset(8)]
	public long Parsed_len;
}
