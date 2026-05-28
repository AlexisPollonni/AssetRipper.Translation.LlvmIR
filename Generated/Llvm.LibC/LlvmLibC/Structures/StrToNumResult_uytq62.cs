using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14StrToNumResultIgEE")]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.3476")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_uytq62
{
	[FieldOffset(0)]
	public double Value;

	[FieldOffset(16)]
	public int Error;

	[FieldOffset(24)]
	public long Parsed_len;
}
