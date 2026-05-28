using System.Runtime.InteropServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Enumerations;

namespace LlvmLibC.Structures;

[StructLayout(LayoutKind.Explicit, Size = 2)]
[MangledName("_ZTSN19__llvm_libc_20_1_2_11printf_core8TypeDescE")]
[MangledName("struct.__llvm_libc_20_1_2_::printf_core::TypeDesc")]
[DemangledName("__llvm_libc_20_1_2_::printf_core::TypeDesc")]
public partial struct Printf_core_TypeDesc
{
	[FieldOffset(0)]
	public sbyte Size;

	[FieldOffset(1)]
	public PrimaryType Primary_type;
}
