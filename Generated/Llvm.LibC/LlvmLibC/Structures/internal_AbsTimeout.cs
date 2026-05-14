using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal10AbsTimeoutE")]
[MangledName("class.__llvm_libc_20_1_2_::internal::AbsTimeout")]
[DemangledName("__llvm_libc_20_1_2_::internal::AbsTimeout")]
public partial struct internal_AbsTimeout
{
	[FieldOffset(0)]
	public AuxEntry timeout;

	[FieldOffset(16)]
	public sbyte realtime_flag;

	[FieldOffset(17)]
	public InlineArray7_SByte field_2;
}
