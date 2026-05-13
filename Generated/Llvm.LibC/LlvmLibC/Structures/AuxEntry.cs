using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("struct.__llvm_libc_20_1_2_::AuxEntry")]
[DemangledName("__llvm_libc_20_1_2_::AuxEntry")]
public partial struct AuxEntry
{
	[FieldOffset(0)]
	public long tv_sec;

	[FieldOffset(8)]
	public long tv_nsec;
}
