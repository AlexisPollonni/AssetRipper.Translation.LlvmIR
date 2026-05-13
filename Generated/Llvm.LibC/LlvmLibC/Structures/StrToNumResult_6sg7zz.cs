using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 32)]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.3407")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_6sg7zz
{
	[FieldOffset(0)]
	public double value;

	[FieldOffset(16)]
	public int error;

	[FieldOffset(24)]
	public long parsed_len;
}
