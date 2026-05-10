using System.Runtime.InteropServices;
using LlvmLibC.Helpers;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("class.__llvm_libc_20_1_2_::AuxvErrnoGuard")]
[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard")]
public partial struct AuxvErrnoGuard
{
	[FieldOffset(0)]
	public int saved;

	[FieldOffset(4)]
	public sbyte failure;

	[FieldOffset(5)]
	public InlineArray3_SByte field_2;
}
