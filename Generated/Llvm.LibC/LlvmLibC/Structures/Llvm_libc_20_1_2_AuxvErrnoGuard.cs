using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 8)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_14AuxvErrnoGuardE")]
[MangledName("class.__llvm_libc_20_1_2_::AuxvErrnoGuard")]
[DemangledName("__llvm_libc_20_1_2_::AuxvErrnoGuard")]
public partial struct Llvm_libc_20_1_2_AuxvErrnoGuard
{
	[FieldOffset(0)]
	public int Saved;

	[FieldOffset(4)]
	public sbyte Failure;

	[FieldOffset(5)]
	public InlineArray3_SByte field_2;
}
