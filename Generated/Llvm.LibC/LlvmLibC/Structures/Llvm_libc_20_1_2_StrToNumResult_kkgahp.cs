using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14StrToNumResultIdEE")]
[MangledName("struct.__llvm_libc_20_1_2_::StrToNumResult.26")]
[DemangledName("__llvm_libc_20_1_2_::StrToNumResult")]
[CleanName("Llvm_libc_20_1_2_StrToNumResult")]
public partial struct Llvm_libc_20_1_2_StrToNumResult_kkgahp
{
	[FieldOffset(0)]
	public Llvm_libc_20_1_2_internal_ExpandedFloat_i7t5up Value;

	[FieldOffset(8)]
	public int Error;

	[FieldOffset(16)]
	public long Parsed_len;
}
