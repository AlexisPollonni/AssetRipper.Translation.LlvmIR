using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 64)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_13AppPropertiesE")]
[MangledName("struct.__llvm_libc_20_1_2_::AppProperties")]
[DemangledName("__llvm_libc_20_1_2_::AppProperties")]
public partial struct AppProperties
{
	[FieldOffset(0)]
	public long page_size;

	[FieldOffset(8)]
	public unsafe void* args;

	[FieldOffset(16)]
	public TLSImage tls;

	[FieldOffset(48)]
	public unsafe void* env_ptr;

	[FieldOffset(56)]
	public unsafe void* auxv_ptr;
}
