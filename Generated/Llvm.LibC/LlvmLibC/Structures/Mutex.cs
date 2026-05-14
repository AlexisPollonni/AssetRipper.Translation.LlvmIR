using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 24)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_5MutexE")]
[MangledName("class.__llvm_libc_20_1_2_::Mutex")]
[DemangledName("__llvm_libc_20_1_2_::Mutex")]
public partial struct Mutex
{
	[FieldOffset(0)]
	public fputil_internal_FPRepImpl_vhj4tm RawMutex;

	[FieldOffset(4)]
	public sbyte timed;

	[FieldOffset(5)]
	public sbyte recursive;

	[FieldOffset(6)]
	public sbyte robust;

	[FieldOffset(7)]
	public sbyte pshared;

	[FieldOffset(8)]
	public int owner;

	[FieldOffset(16)]
	public long lock_count;
}
