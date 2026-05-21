using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 64)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_13AppPropertiesE")]
[MangledName("struct.__llvm_libc_20_1_2_::AppProperties")]
[DemangledName("__llvm_libc_20_1_2_::AppProperties")]
public partial struct Llvm_libc_20_1_2_AppProperties
{
	[FieldOffset(0)]
	public long Page_size;

	[FieldOffset(8)]
	public unsafe void* Args;

	[FieldOffset(16)]
	public Llvm_libc_20_1_2_TLSImage Tls;

	[FieldOffset(48)]
	public unsafe void* Env_ptr;

	[FieldOffset(56)]
	public unsafe void* Auxv_ptr;
}
