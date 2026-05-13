using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.0.3435")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_aztiru
{
	[FieldOffset(0)]
	public long value;

	[FieldOffset(8)]
	public int error;

	[FieldOffset(16)]
	public long parsed_len;
}
