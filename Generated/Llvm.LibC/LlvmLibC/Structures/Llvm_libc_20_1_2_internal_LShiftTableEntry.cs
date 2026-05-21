using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 16)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_8internal16LShiftTableEntryE")]
[MangledName("struct.__llvm_libc_20_1_2_::internal::LShiftTableEntry")]
[DemangledName("__llvm_libc_20_1_2_::internal::LShiftTableEntry")]
public partial struct Llvm_libc_20_1_2_internal_LShiftTableEntry
{
	[FieldOffset(0)]
	public int New_digits;

	[FieldOffset(8)]
	public unsafe void* Power_of_five;
}
