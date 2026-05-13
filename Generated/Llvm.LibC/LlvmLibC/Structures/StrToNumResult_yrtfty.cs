using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.0.3427")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_yrtfty
{
	[FieldOffset(0)]
	public int value;

	[FieldOffset(4)]
	public int error;

	[FieldOffset(8)]
	public long parsed_len;
}
