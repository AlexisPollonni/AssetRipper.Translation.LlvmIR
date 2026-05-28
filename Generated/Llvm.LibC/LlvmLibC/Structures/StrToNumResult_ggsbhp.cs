using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 48)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14StrToNumResultINS_8internal13ExpandedFloatIeEEEE")]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.12")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("StrToNumResult")]
public partial struct StrToNumResult_ggsbhp
{
	[FieldOffset(0)]
	public Internal_ExpandedFloat_9jummq Value;

	[FieldOffset(32)]
	public int Error;

	[FieldOffset(40)]
	public long Parsed_len;
}
