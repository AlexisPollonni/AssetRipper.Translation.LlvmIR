using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14StrToNumResultIgEE")]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_c5b6ms
{
	[FieldOffset(0)]
	public double value;

	[FieldOffset(16)]
	public int error;

	[FieldOffset(24)]
	public long parsed_len;
}
