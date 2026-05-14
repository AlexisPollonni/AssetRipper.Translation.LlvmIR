using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14StrToNumResultIDF16_EE")]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.0.1434")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_wwcts2
{
	[FieldOffset(0)]
	public short value;

	[FieldOffset(4)]
	public int error;

	[FieldOffset(8)]
	public long parsed_len;
}
